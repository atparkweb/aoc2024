namespace AoC24

open System
open System.IO

module Program =
    [<EntryPoint>]
    let main _args =
        let input =
            CommonUtils.getAbsoluteContentPath("input/day2.txt")
            |> File.ReadAllLines
            |> Array.map (fun line -> (Array.map Int32.Parse (line.Split " ")))

        let answer = Day2.solve input
        printfn $"The answer is: {answer}"
        0