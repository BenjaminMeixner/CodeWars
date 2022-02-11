module Fibonacci

    open Xunit
    open FsUnit.Xunit

    let result = (2, 3, true)
    
    let rec atIndex idx previous current =
        if idx = 0 then
            previous
        else
            atIndex (idx - 1) current (previous + current)
    let AtIndex idx =
        atIndex idx 0 1
        
    [<Fact>]
    let ``known index results`` () =
        AtIndex 0 |> should equal 0 
        AtIndex 1 |> should equal 1 
        AtIndex 2 |> should equal 1 
        AtIndex 6 |> should equal 8 
        AtIndex 13 |> should equal 233
        