module Day2Tests

open AoC24
open Xunit

[<Fact>]
let ``Finds the correct number of safe reports`` () =
    Assert.Equal(1, Day2.solve [|[|1; 2; 3; 4|]|])
    Assert.Equal(0, Day2.solve [|[|2; 4; 1; 5|]|])