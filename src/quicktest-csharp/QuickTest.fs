module QuickTest

open System
open System.Text.RegularExpressions
open System.Collections.Generic
open Fable.Core
// open Fable.Core.Dart

// let equal expected actual =
//    let areEqual = expected = actual
//    print $"{expected} = {actual} > {areEqual}"
//    if not areEqual then
//        print $"[ASSERT ERROR] Expected {expected} but got {actual}"
//        exn "" |> raise

// let testCase (msg: string) f: unit =
//     print msg
//     f ()
//     print ""

// let testList (msg: string) (xs: unit list): unit =
//     ()

// let throwsAnyError (f: unit -> 'a): unit =
//     let success =
//         try
//             f() |> ignore
//             true
//         with e ->
//             print $"Got expected error: %s{string e}"
//             false
//     if success then
//         print "[ERROR EXPECTED]"

// let compose f g = fun x -> f (g x)

// type IPerson =
//     abstract Name: string
//     abstract Age: int
//     abstract HaveBirthday: unit -> IPerson

// type Person() =
//     member val Name = "" with get, set

// let fold (f: 'A -> 'B -> 'A) (acc: 'A) (xs: 'B list): 'A =
//     let rec loop acc xs =
//         match xs with
//         | [] -> acc
//         | x :: xs -> loop (f acc x) xs
//     loop acc xs

// let add x y = x + y

// let main(args: string[]) =
//     ()

let Hello() =
    Console.WriteLine("Hello World!");