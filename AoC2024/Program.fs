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
        
        // Print out the solutions to the console
        [| day1; day2; |] |> Array.iter (fun (i, a) -> printfn $"Day {i} answer: {a}")
        0