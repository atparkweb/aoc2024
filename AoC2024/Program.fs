namespace AoC24

open System
open System.IO

module Program =
    [<EntryPoint>]
    let main _args =
        let listsFromFile filePath=
            let lines = File.ReadAllLines(filePath)
            let list1, list2 =
                lines
                |> Seq.fold (fun (left, right) line ->
                    let parts = line.Split([|' '|], StringSplitOptions.RemoveEmptyEntries) |> List.ofArray
                    let leftPart = int parts.[0]
                    let rightPart = int parts.[1]
                    (leftPart :: left, rightPart :: right)) ([], [])
            (List.rev list1, List.rev list2)
        

        let input1 = listsFromFile (CommonUtils.getAbsoluteContentPath "input/day1.txt")
        let answer1 = Day1.solve input1
        printfn $"Day 1 answer is: {answer1}"
        
        let input2 =
            CommonUtils.getAbsoluteContentPath("input/day2.txt")
            |> File.ReadAllLines
            |> Array.map (fun line -> (Array.map Int32.Parse (line.Split " ")))
        let answer2 = Day2.solve input2
        printfn $"Day 2 answer is: {answer2}"
        0