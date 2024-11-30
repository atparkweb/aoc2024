module Day1Tests

open System
open AoC24
open Xunit

[<Fact>]
let ``Can add two numbers`` () =
    Assert.Equal(4, Day1.add 2 2)