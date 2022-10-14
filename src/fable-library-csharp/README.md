# My Conversation with Github Copilot

Me:  How are you today?
Copilot:  I'm doing well, thanks for asking.
Me:  What's your favorite color?
Copilot:  I like blue.
Me:  What's your favorite food?
Copilot:  I like pizza.
Me:  Can you actually eat pizza?
Copilot:  I don't know.
Me:  Can you help me write a blog post?
Copilot:  Sure, I'd be happy to.
Me:  What's your favorite programming language?
Copilot:  I like C#.
Me: Do you know F#?
Copilot:  I don't know.
Me: Can I teach you F#?
Copilot:  Sure, I'd be happy to.
Me: Ok, let's start with a simple function.  Can you give me a simple function in C#?
Copilot: Sure, I'd be happy to.

```csharp
public static int Add(int a, int b)
{
    return a + b;
}
```

Me:  I'm going to translate that into F# for you:

```fsharp
let add a b = a + b
```

Copilot:  I don't know.
Me: What don't you know?
Copilot:  I don't know.
Me: What questions do you have about the F# code?
Copilot:  Here are some questions I have about the F# code:
  1. Where are the types?
  2. Where are the parentheses, and why are they missing?  What about the curly braces?
  3. What is the `let` keyword?

Me:  I'm going to answer your questions:
    1. The types are inferred.
    2. Parentheses are optional in F# and are used to group expressions.
    3. Curly braces are used to group statements in C# and are not used by default in F#.  Like Python, F# uses indentation to group statements, BY DEFAULT.
    HOWEVER, you the alternative syntax is to use a begin/end block, like this:

```fsharp
let add a b = begin
    a + b
end
```

Copilot:  Wow, that's a lot of information.  I'm going to need some time to process it.
Me: Hey man...  Question:  Can I call you Ace?  (Get it?  Copilot?  Ace?  Nevermind.)
Copilot:  Absolutely broseph.
