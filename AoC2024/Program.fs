namespace AoC24

open AoC2024.input.Day1_input

module Program =
    [<EntryPoint>]
    let main _args =
        let answer = Day1.solve input1 input2
        printfn $"The answer is: {answer}"
        0