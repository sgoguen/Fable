# F# &harr; C# &mdash; What would it take?

I've been wondering recently what would be involved to make a C# target for the Fable compiler. What would it take to make a tool that can convert C# into F#?

Right of the bat, I know this is a difficult and time consuming project for someone who has experience doing this sort of thing. I've never written a real compiler before and I know I am absolutely over my head with something like this, but I want to try anyway.

----

## 1. My Motivation

I want to learn why it's hard on a personal level, not on a handwavey abstract level.

I want to fail publicly and keep trying and see where I get.

I want to grow from trying something hard and I want to work on something that interests me.

I want to work and learn from this every day like it's a big quilt for the next year. I need something consistent in my life that isn't work that's important to me and it's more important to me that I do something every day rather than trying to race through it.

----

## 2. My First Plan - A Very Minimal Viable Product

My first goal is to beg, borrow and steal.

And the Fable project is a wonderful project to steal other people's ideas and code. I don't know about you, but I don't know of any other transpiler project that endeavours to tranpile a single commercially supported language and translate them into 6 different languages.

I think this snippet from the Fable command-line utility says it all:

```fsharp
let getStatus = function
    | JavaScript -> "beta"
    | Python -> "beta"
    | Dart -> "beta"
    | Rust -> "alpha"
    | TypeScript -> "alpha"
    | Php -> "experimental"
    | CSharp -> "experimental"   //  Newly added to my fork
```
----

## Borrowing from Dart

My primary goal is to learn how to translate F# &harr; C# with an emphasis on the **learning** part, so I set out to get this working:

```bash
dotnet fable --lang csharp
```

...even if it's outputting Dart code in .cs files

Dart seemed a good first option. Alfonso García-Caro has been
investing a lot of his time and energy in it. Seeing how he birthed this project, I chose him to be my first teacher.

------

## And Then I Forked It!

The Fable project is made up of more than a dozen subprojects.  To fork Dart, I focus on these three key projects:

| Project          | Description                                                             |
|------------------|-------------------------------------------------------------------------|
| src/Fable.AST        | Defines the core abstract syntax tree for the Fable compiler            |
| src/Fable.Transforms | All the Fable &rarr; language transformation code lives here.           |
| src/Fable.Cli        | The actual command-line program that loads the F# projects and compiles |
| src/fable-library[-lang] | Each language needs to implement the Fable runtime library          |
| src/quick-test[-lang]| These projects are used quickly test features and experiment with the compiler |
| tests/[lang] | Unit tests for each language |

Here's what I did:

1. I started with Fable.Transforms and copied the Dart subdirectory and did a bunch of renaming.
    * I just wanted it to compile, so I can add the language to the CLI
2. I cloned the Dart language library and replaced mentions of Dart with CSharp.  I'm deferring
   implementing this.
3. Added the CSharp target to *Fable.Cli*
4. Cloned **quick-test-dart** to **quick-test-csharp**
5. To the build script (build.fsx), I added a target quicktest-csharp so I can start playing around.

## Testing it!!!!

Eager to get started, I ran this command:

```bash
sh build.sh quicktest-csharp
```

What I got back was Dart code.