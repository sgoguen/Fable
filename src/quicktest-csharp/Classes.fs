module Classes.Tests

open Fable.Core

let x = 1
let length (xs: 'a[]) = xs.Length
// [<AttachMembers>]
// type PersonClass(name: string, age: int) =
//     let nextYearAge = age + 1
//     member this.Name = name
//     member this.Age = age
//     member this.NextYearAge = nextYearAge
    // member this.SayHello() =
    //     printfn "Hello, my name is %s and I'm %d years old" name age

// type PersonRecord =
//     { Name: string
//       Age: int }

// type PersonUnion =
//     | Person of name: string * age: int