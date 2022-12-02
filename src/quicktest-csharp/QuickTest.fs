open Fable.Core

[<Emit("Console.WriteLine($0)")>]
let print(msg: string) = jsNative

let add x y = x + y

let addNumbers (list: int[]) =
    let mutable sum = 0
    for i in list do
        sum <- add sum i
    sum


// let sumList list =
//     let rec sumRec (sum) (list: int list) =
//         match list with
//         | [] -> sum
//         | x :: xs -> sumRec (x + sum) xs
//     sumRec 0 list

let execute f =
    f()
    0

let returnCode = execute (fun () ->
    print "Hello World!!"
)
