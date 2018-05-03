module Fable.Tests.Main

let allTests =
  [| Applicative.tests
     Arithmetic.tests
     Async.tests
     Arrays.tests
     Char.tests
     Comparison.tests
     Dictionaries.tests
     HashSets.tests
     Lists.tests
     Seqs.tests
     Sets.tests
     Maps.tests
     Option.tests
  |]

#if FABLE_COMPILER

open Fable.Core

let [<Global>] describe (name: string) (f: unit->unit) = jsNative
let [<Global>] it (msg: string) (f: unit->unit) = jsNative

let run () =
    for (name, tests) in allTests do
        describe name (fun () ->
            for (msg, test) in tests do
                it msg (unbox test))
run()

#else

open Expecto

[<EntryPoint>]
let main args =
  Array.toList allTests
  |> testList "All"
  |> runTestsWithArgs defaultConfig args

#endif
