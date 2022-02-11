module Judge.PerfectSquareTest

open Xunit
open FsUnit.Xunit
open Kata.PerfectSquare

[<Fact>]
let ``perfect squares`` () =
    IsPerfectSquare 0 |> should equal true
    IsPerfectSquare 1 |> should equal true
    IsPerfectSquare 4 |> should equal true
    IsPerfectSquare 9 |> should equal true
    IsPerfectSquare 16 |> should equal true
    IsPerfectSquare 25 |> should equal true
    IsPerfectSquare 144 |> should equal true
    IsPerfectSquare 625 |> should equal true
    
[<Fact>]
let ``not perfect squares`` () =
    IsPerfectSquare 2 |> should equal false
    IsPerfectSquare 5 |> should equal false
    IsPerfectSquare 8 |> should equal false
    IsPerfectSquare 33 |> should equal false
    IsPerfectSquare 334 |> should equal false
    IsPerfectSquare 200 |> should equal false
    IsPerfectSquare 9999 |> should equal false
    IsPerfectSquare 84729 |> should equal false
