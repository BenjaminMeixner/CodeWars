module Kata.FibonacciPattern

open Xunit
open FsUnit.Xunit

let rec AtIndex n =
    match n with
    | 0 | 1 -> n
    | n -> AtIndex (n-2) + AtIndex (n-1)

[<Fact>]
let ``known index results`` () =
    AtIndex 0 |> should equal 0 
    AtIndex 1 |> should equal 1 
    AtIndex 2 |> should equal 1 
    AtIndex 6 |> should equal 8 
    AtIndex 13 |> should equal 233

