module Tests

open System
open Xunit

type Expr =
    static member From<'T>([<ReflectedDefinition>] e: Quotations.Expr<'T>) = e

[<Fact>]
let ``My test`` () =
    let e = Expr.From(2 + 2)
    //  Convert the F# to a Fable expression

    Assert.True(true)
