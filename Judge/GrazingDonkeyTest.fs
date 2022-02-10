module Judge.GrazingDonkeyTest

open Kata
open Xunit
open GrazingDonkey
open FsUnit.Xunit

[<Fact>]
let ``0 Diameter returns always 0`` () =
    ogreSteps 0 0.5 |> should equal 0
   
[<Fact>]
let ``0 Percent returns always 0`` () =
    ogreSteps 5 0 |> should equal 0
    
[<Fact>]
let ``100 Percent returns diameter`` () =
    ogreSteps 5 1 |> should equal 5
    ogreSteps 10 1 |> should equal 10
    ogreSteps 1000 1 |> should equal 1000
    
[<Fact>]
let ``some chosen values`` () =
    ogreSteps 5 0.2 |> should equal 2
    ogreSteps 10 0.4 |> should equal 6
    ogreSteps 1000 0.8 |> should equal 894
    ogreSteps 1000 0.3 |> should equal 547
    ogreSteps 1000 0.7 |> should equal 836
