module Day1Tests

open System
open AoC24
open Xunit

[<Fact>]
let ``Returns zero when both lists are empty`` () =
    Assert.Equal(0, Day1.solve ([], []))
    
[<Fact>]
let ``Raises an argument exception when lists are different lengths`` () =
    Assert.Throws<ArgumentException>(fun () -> Day1.solve ([1; 2; 3], [4; 5]) |> ignore)
    
[<Fact>]
let ``Can get total difference between lists that contain 1 item each`` () =
    Assert.Equal(1, Day1.solve ([2], [3]))
    
[<Fact>]
let ``Can get total difference between pairs of taken from two lists`` () =
    Assert.Equal(11, Day1.solve ([3; 4; 2; 1; 3; 3 ], [4; 3; 5; 3; 9; 3]))
