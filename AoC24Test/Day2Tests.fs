module Day2Tests

open AoC24
open Xunit

[<Fact>]
let ``Counts empty levels as "safe"`` () =
    Assert.Equal(1, Day2.solve [| [||] |])
    Assert.Equal(2, Day2.solve [| [||]; [||] |])
    
[<Fact>]
let ``Counts ascending ordered levels as "safe"`` () =
    Assert.Equal(1, Day2.solve [| [| 1; 2; 3; 4 |] |])
    Assert.Equal(2, Day2.solve [| [| 1; 4; 5; 6 |]; [| 7; 9; 11; 13 |] |])
                                 
[<Fact>]
let ``Counts descending ordered levels as "safe"`` () =
    Assert.Equal(1, Day2.solve [| [| 4; 3; 2; 1 |] |])
    Assert.Equal(2, Day2.solve [| [| 9; 8; 7; 6 |]; [| 5; 3; 2; 1 |] |])

[<Fact>]
let ``Counts unordered report as "unsafe"`` () =
    Assert.Equal(0, Day2.solve [| [| 1; 4; 3; 7; 2 |] |])
    
[<Fact>]
let ``Counts level change of 0 as "unsafe"`` () =
    Assert.Equal(0, Day2.solve [| [| 1; 2; 2; 4; 5 |] |])

[<Fact>]
let ``Counts level change over 3 as "unsafe"`` () =
    Assert.Equal(0, Day2.solve [| [| 1; 2; 7; 8; 9 |]; [|5; 10; 20|] |])
