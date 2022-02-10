module Judge.GrazingDonkeyTest

open Kata
open Xunit
open GrazingDonkey

[<Fact>]
let ``0 Diameter returns always 0`` () =
    Assert.Equal(0, ogreSteps 0)