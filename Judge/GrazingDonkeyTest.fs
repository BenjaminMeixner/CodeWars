module Judge.GrazingDonkeyTest

open Kata
open Xunit
open GrazingDonkey
open FsUnit.Xunit

[<Fact>]
let ``0 Diameter returns always 0`` () =
    OgreSteps 0 0.5 |> should equal 0
   
[<Fact>]
let ``0 Percent returns always 0`` () =
    OgreSteps 5 0 |> should equal 0
    
[<Fact>]
let ``100 Percent returns diameter`` () =
    OgreSteps 5 1 |> should equal 5
    OgreSteps 10 1 |> should equal 10
    OgreSteps 1000 1 |> should equal 1000
    
[<Fact>]
let ``some chosen values`` () =
    OgreSteps 5 0.2 |> should equal 2
    OgreSteps 10 0.4 |> should equal 6
    OgreSteps 1000 0.8 |> should equal 894
    OgreSteps 1000 0.3 |> should equal 547
    OgreSteps 1000 0.7 |> should equal 836
