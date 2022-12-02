module MyTests

open System
open Fable.Core

let x = 1

module Array =
    let length (xs: 'a[]) = xs.Length
    let map (f: 'a -> 'b) (xs: 'a[]) =
        let ys = Array.zeroCreate xs.Length
        for i = 0 to xs.Length - 1 do
            ys.[i] <- f xs.[i]
        ys
    let filter (f: 'a -> bool) (xs: 'a[]) =
        let ys = Array.zeroCreate xs.Length
        let mutable j = 0
        for i = 0 to xs.Length - 1 do
            if f xs.[i] then
                ys.[j] <- xs.[i]
                j <- j + 1
        Array.sub ys 0 j

    let fold (f: 'a -> 'b -> 'a) (acc: 'a) (xs: 'b[]) =
        let mutable acc = acc
        for i = 0 to xs.Length - 1 do
            acc <- f acc xs.[i]
        acc

    let foldBack (f: 'a -> 'b -> 'b) (xs: 'a[]) (acc: 'b) =
        let mutable acc = acc
        for i = xs.Length - 1 downto 0 do
            acc <- f xs.[i] acc
        acc

    let pick (f: 'a -> 'b option) (xs: 'a[]) =
        let ys = Array.zeroCreate xs.Length
        let mutable j = 0
        for i = 0 to xs.Length - 1 do
            match f xs.[i] with
            | Some y ->
                ys.[j] <- y
                j <- j + 1
            | None -> ()
        Array.sub ys 0 j

    let inline pickValue (f: 'a -> struct(bool * 'b)) (xs: 'a[]) =
        let ys = Array.zeroCreate xs.Length
        let mutable j = 0
        for i = 0 to xs.Length - 1 do
            match f xs.[i] with
            | (true, y) ->
                ys.[j] <- y
                j <- j + 1
            | (false, _) -> ()
        Array.sub ys 0 j

// let name = "Steve"
// let mutable greeting = sprintf "Hello %s" name
// let mutable greeting2 = "Hello " + name

// [<AttachMembers>]
// type Person(name: string, dob: DateTime) =
//     let age() = (DateTime.Now.Year - dob.Year)
//     member this.Name = name
//     // member this.Age = DateTime.Now.Year - dob.Year
//     member this.Age = age()
//     member this.DOB = dob

// let bob = Person("Bob", DateTime(1980, 1, 1))
// let bobAge = bob.Age

// type PersonRecord = { Name: string; DOB: DateTime }

// let bob1 = { Name = "Bob"; DOB = DateTime(1980, 1, 1) }
// let bob2 = { Name = "Bob"; DOB = DateTime(1980, 1, 1) }
// // let areBobsTheSame = (bob1 = bob2)