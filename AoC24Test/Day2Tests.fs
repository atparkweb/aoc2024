module Day2Tests

open AoC24
open Xunit

[<Fact>]
let ``Finds the correct number of safe reports`` () =
    Assert.Equal(0, Day2.solve)