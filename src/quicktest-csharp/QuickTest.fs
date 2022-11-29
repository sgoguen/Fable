open Fable.Core

[<Emit("Console.WriteLine($0)")>]
let print(msg: string) = jsNative

let execute f =
    f()
    0

let returnCode = execute (fun () ->
    print "Hello World!!"
)
