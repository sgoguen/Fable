# The Time I Made the Fable Compiler Translate Hello World to C#

* [Introduction](#introduction)
* [Transforming F# to C#](#transforming-f-to-c)
* [Copying the Dart Target](#copying-the-dart-target)
* [Basics of the Fable Compiler Transformation](#basics-of-the-fable-compiler-transformation)
    * [Step 1 - Define Source and Target ASTs](#step-1---define-source-and-target-asts)
    * [Step 2 - Transform AST -> AST](#step-2---transform-ast--ast)
    * [Step 3 - Generate Code](#step-3---generate-code)
* [Getting to C# Hello World](#getting-to-hello-world)
    * [What was wrong with the Dart target?](#what-was-wrong-with-the-dart-target)
        # [Dart doesn't support top-level statements](#1-dart-doesnt-support-top-level-statements)
        # [Supporting Console.WriteLine](#2-supporting-consolewriteline)
        # [Syntax Differences Defining Functions](#3-syntax-differences-defining-functions)
        # [C# doesn't support the `final` keyword](#4-c-doesnt-support-the-final-keyword)
        # [Fixing the Lambda Syntax for C#](#5-fixing-the-lambda-syntax-for-c)
        # [Dart uses single quotes for strings](#6-dart-uses-single-quotes-for-strings)
        # [I guess I have to fix how we print function types](#7-i-guess-i-have-to-fix-how-we-print-function-types)
    * [All that just to get to Hello World!](#all-that-just-to-get-to-hello-world)



## Introduction

I used to frequent a hack night meetup where we would go to a Starbucks and work on side-projects. The way it worked was each person would share their goal for the evening and then we would sit there together quietly for the next 3-4 hours and demo what we did at the end.

It's a fun exercise in reducing the scope.

Recently, I decided to do something similar with the Fable compiler. I wanted to see if I could make it translate a simple F# program to a *TINY* subset of C# so I could start iterating on a C# backend for Fable and learn more about the compiler.

## Transforming F# to C#

The Fable compiler allows you to create targets for different languages. The default target is JavaScript, but in the last few years, we've added support for other languages like TypeScript, Python, PHP and Rust.  Most are alpha or experimental, but the Fable compiler is young and I think there's so much potential for it to be a great tool.

With that, I wanted to understand the actual challenges of creating a C# target rather than just thinking about it. I figured the best way to do that was to start with a simple program and see how far I could get.

## Copying the Dart Target

For this example, I started by copying the Dart target from the Fable repository just to get started. I thought the Dart target would be a good starting point because it's a statically typed language like C#, but I'm not sure if that was the best choice.

Nevertheless, it's a good learning experience.

## Basics of the Fable Compiler Transformation

The 50,000 foot view of the Fable compiler can be broken down into 3 steps:

1. Parsing the F# AST (Abstract Syntax Tree)
2. Transforming the F# AST to a Target Language AST
3. Printing the Target Language AST to a string (The actual code)

### Step 1 - Define Source and Target ASTs

Fortunately for us, parsing F# has already been handled. We get to focus on the fun part: Transforming the F# AST to a C# AST.

Here's where you can find the ASTs for each language:

| Language | AST File |
| --- | --- |
| F# | ./src/Fable.AST/Fable.fs |
| C# | ./src/Fable.Transforms/CSharp/CSharp.fs |
| Dart | ./src/Fable.Transforms/Dart/Dart.fs |
| Python | ./src/Fable.Transforms/Python/Python.fs |
| PHP | ./src/Fable.Transforms/PHP/PHP.fs |
| JavaScript | ./src/Fable.Transforms/Globals/Babel.fs |
| Rust | ./src/Fable.Transforms/Rust/Rust/AST/*.fs (This is broken up into separate files) |

(**Now might be a good time to take a cursory look at the code**)

### Step 2 - Transform AST -> AST

In the same folders as the AST, you'll typically find a file called `Fable2[LangName].ts` that holds the main transformation logic.

That logic is supported by a set of helper functions in the `Replacements.fs` file, which helps the Fable compiler transform .NET and F# specific library calls into their target language equivalents.

Usually, the F# standard library has to be rewritten for each target language. For example, the F# Mailbox Processor is something that doesn't exist in JavaScript/TypeScript, so it was rewritten in TypeScript.  You can check it out here: `./src/fable-library/MailboxProcessor.ts`.

It's pretty wild!

### Step 3 - Generate Code

The last part of the Fable compiler is the printer.  The printer takes the target language AST and turns it into a string.  You can think of it as the inverse of the parser.
