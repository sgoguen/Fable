# F# &rarr; C# &mdash; Making Dart Code Look like C#

In part 1, I was able to get the Fable compiler to output Dart code in .cs files.  This is a good start, but I want to get the code to look more like C# so we can actually run it.

The first thing I wanted to do was not worry about C# Projects for now, so I'm targeting CSX files, which are C# scripts and I'm using the [dotnet-script]() tool to run them.

```bash
dotnet tool install -g dotnet-script
```

I updated the CLI to produce a .csx file instead of a .dart file and worked towards "Hello World"

## Problem 1 - Dart doesn't support top-level statements

```fsharp
printfn "Hello World"
```

This is a top-level statement.  It's not supported in Dart.  What I can do is define a variable and assign it to the result of the top-level statement like so:

```fsharp
let returnCode =
    printfn "Hello World"
    0
```

That generates Dart code that looks like this:

```dart
import 'fable-library/String.dart' as string;

final returnCode = (() {
    string.toConsole<void>(string.printf<void, TextWriter, void, void, void>('Hello World'));
    return 0;
})();
```

There's so much wrong here, so let's simplify:

1. We're going to avoid printfn for now.  We'll write a simple function that uses Fable's Emit attribute to emit the Console.WriteLine method instead.  (We're bootstrapping!)
2. Next, we'll get into the Fable compiler and start changing the output.

First, let's define a function that uses the Emit attribute:

```fsharp
open Fable.Core

[<Emit("Console.WriteLine($0)")>]
let print(msg: string) = jsNative

let returnCode =
    print "Hello World"
    0
```

The Dart code is smaller, but we need it to look like C# code:

```dart
final returnCode = (() {
    Console.WriteLine('Hello World');
    return 0;
})();
```

1. C# doesn't declare variables with the `final` keyword.
2. C# lambdas require the `=>` operator between the parameters and body.
3. We can't define a lambda function and immediately execute it in C# like that.

Fixing the final keyword and adding the `=>` operator is easier than fixing the issue where we immediately execute the lambda function, but let's talk about the Fable compiler before we dive into it:


-----

## Fable.Transforms - Autobots, Roll Out!

[https://media.giphy.com/media/fl9WeVqXsGmHK/giphy.gif](https://media.giphy.com/media/fl9WeVqXsGmHK/giphy.gif)

We're going to focus on the Fable.Transforms project, specifically the CSharp subfolder.  In this folder, there are 4 files:

| File | Description |
| --- | --- |
| CSharp.fs | This module defines the C# AST (Which is actually the Dart AST).  There's no transformations here, just data types representing the C# code. |
| Fable2CSharp.fs | This module defines the transformations that take the F# AST and convert it to the C# AST.  It's the fattest of the modules and most of the work is done here. |
| CSharpPrinter.fs | When the Fable compiler is done transforming the F# AST to the C# AST, we then send that C# AST object to the CSharpPrinter module to generate the C# code. |
| Replacements.fs | This module assists the Fable2CSharp module by assisting with standard library and data type transformations.  This is more about runtime stuff and less about language features. |

-----

## Fixing the CSharpPrinter.fs

Let's fix the first two problems in the CSharpPrinter.fs file so we can familiarize ourselves with it.  Take some time to quickly survey the code.  It's mostly made up of match expressions and calls to printer.Print("...") to output the C# code.

If I search for `final` in the file, I find three places where it's used:

```fsharp
            | ForInStatement(param, iterable, body) ->
                printer.Print("for (final " + param.Name + " in ")
                printer.PrintWithParensIfComplex(iterable)
                printer.Print(") ")
                printer.PrintBlock(body)
```

We can safely change that final keyword to var.

OK!  Next we find this large block of code that prints variable declarations:

```fsharp
        member printer.PrintVariableDeclaration(ident: Ident, kind: VariableDeclarationKind, ?value: Expression, ?isLate) =
            let value =
                match value with
                | None -> None
                // Dart recommends not to explicitly initialize mutable variables to null
                | Some(Literal(NullLiteral _)) when kind = Var -> None
                | Some v -> Some v

            match value with
            | None ->
                match isLate, ident.Type with
                | Some false, _
                | None, Nullable _ -> ()
                | Some true, _
                // Declare as late so Dart compiler doesn't complain var is not assigned
                | None, _ -> printer.Print("late ")  //  DO WE CHANGE THIS TO "var"????
                match kind with
                | Final -> printer.Print("final ")   // <--- CHANGE THIS TO "var"
                | _ -> ()
                printer.PrintType(ident.Type)
                printer.Print(" " + ident.Name)

            | Some value ->
                let printType =
                    // Nullable types and unions usually need to be typed explicitly
                    // Print type also if ident and expression types are different?
                    // (this usually happens when removing unnecessary casts)
                    match ident.Type with
                    | Nullable _ -> true
                    | TypeReference(_, _, info) -> info.IsUnion
                    | _ -> false

                match kind with
                | Const -> printer.Print("const ")   // <--- DO WE CHANGE THIS TO "var"????
                | Final -> printer.Print("final ")   /// <--- CHANGE THIS TO "var"
                | Var when not printType -> printer.Print("var ")
                | Var -> ()

                if printType then
                    printer.PrintType(ident.Type)
                    printer.Print(" ")

                printer.Print(ident.Name + " = ")
                printer.Print(value)
```

There's a lot going on in this block, and I plan on coming back to understand all the scenarios and deal with it more thorougly, but I want to address the issue superficially for so we can familiarize ourselves with the code.

For now, I'm inclined to not touch the `late` and `const` keywords because I don't understand the implications of changing them yet.

I just want to get my program running.

## Fixing the Lambda Function Syntax

While searching for 'function' in the file, I find this block of code for printing AnonymousFunctions

```fsharp
            | AnonymousFunction(args, body, genArgs, _returnType) ->
                printer.PrintList("<", genArgs, ">", skipIfEmpty=true)
                printer.PrintIdentList("(", args, ")", printType=true)
                printer.PrintFunctionBody(body, isExpression=true)
```

I can fix this quickly by adding the fat arrow between the parameters and body like so:

```fsharp
            | AnonymousFunction(args, body, genArgs, _returnType) ->
                printer.PrintList("<", genArgs, ">", skipIfEmpty=true)
                printer.PrintIdentList("(", args, ")", printType=true)
                printer.Print(" => ")  // <--- ADD THIS
                printer.PrintFunctionBody(body, isExpression=true)
```


## Dart Uses Single Quotes for String Literals

We change this:

```fsharp
           | StringLiteral value ->
                let escape str =
                    (Naming.escapeString (fun _ -> false) str).Replace(@"$", @"\$")
                printer.Print("'")
                printer.Print(escape value)
                printer.Print("'")

```

To this:

```fsharp
           | StringLiteral value ->
                let escape str =
                    (Naming.escapeString (fun _ -> false) str).Replace(@"$", @"\$")
                printer.Print("\"")
                printer.Print(escape value)
                printer.Print("\"")
```

## Fixing How We Print Function Types

Dart function types put the return type before the parameter types like: `int Func<string>`


```fsharp
            | Function(argTypes, returnType) ->
                printer.PrintType(returnType)
                printer.Print(" ")
                // Probably this won't work if we have multiple args
                let argTypes = argTypes |> List.filter (function Void -> false | _ -> true)
                printer.PrintList("Func<", ", ", ">", argTypes, printer.PrintType)
```

In C#, we would write this as `Func<string, int>` but only if we're returning a value.  If we're returning void, we would write it as `Action<string>`.  Here the string is the input type.  If function has neither an input or output type, we would write it as `Action`.

This update to the code should be able to accomodate this for now:

```fsharp
            | Function(argTypes, returnType) ->
                let argTypes = argTypes |> List.filter (function Void -> false | _ -> true)
                match returnType, argTypes with
                | Void, [] -> printer.Print("Action")
                | Void, _ -> printer.PrintList("Action<", ", ", ">", argTypes, printer.PrintType)
                | _, _ -> printer.PrintList("Func<", ", ", ">", [ yield! argTypes; yield returnType ], printer.PrintType)
```

Again, we're not making this perfect, we're just getting it to work and making ourselves familiar with the printer.

With these changes, we can now compile this very simple F# program:

```fsharp
open Fable.Core

[<Emit("Console.WriteLine($0)")>]
let print(msg: string) = jsNative

let execute f =
    f()
    0

let returnCode = execute (fun () ->
    print "Hello World!!"
)
```

Into this very simple C# program:

```csharp
int execute(Action f) {
    f();
    return 0;
}

var returnCode = execute(() =>  {
    Console.WriteLine("Hello World!!");
});
```

Try it out by running `dotnet script QuickTest.fs.csx` in your terminal and you should see that magical:

```
Hello World!!
```