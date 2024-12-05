namespace AoC24

module Program =
    [<EntryPoint>]
    let main _args =
        // Solve Day 1-1
        let input1 = CommonUtils.columnsFromFile "input/day1.txt"
        let day1 = (1, Day1.solve input1)
        
        // Solve Day 2-1
        let input2 = CommonUtils.numericalDataFromFile "input/day2.txt"
        let day2 = (2, Day2.solve input2)
        
        // Solve Day 3-1
        let input3 = CommonUtils.bytesFromFile "input/day3.txt"
        let day3 = (3, Day3.solve input3)
        
        // Print out the solutions to the console
        [| day1; day2; day3; |] |> Array.iter (fun (i, a) -> printfn $"Day {i} answer: {a}")
        0