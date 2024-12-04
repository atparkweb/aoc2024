namespace AoC24

module Program =
    [<EntryPoint>]
    let main _args =
        let answer = Day2.solve
        printfn $"The answer is: {answer}"
        0