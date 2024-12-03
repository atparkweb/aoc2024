namespace AoC24

open System
open System.IO

module public Day1 =
    let private getProjectRootDirectory () =
        let baseDir = AppDomain.CurrentDomain.BaseDirectory
        Directory.GetParent(baseDir).Parent.Parent.Parent.FullName
        
    let private getAbsoluteContentPath filePath =
        Path.Combine(getProjectRootDirectory(), filePath)

    let private listsFromFile filePath=
        let lines = File.ReadAllLines(filePath)
        let list1, list2 =
            lines
            |> Seq.fold (fun (left, right) line ->
                let parts = line.Split([|' '|], StringSplitOptions.RemoveEmptyEntries) |> List.ofArray
                let leftPart = int parts.[0]
                let rightPart = int parts.[1]
                (leftPart :: left, rightPart :: right)) ([], [])
        (List.rev list1, List.rev list2)
        

    let private sortLists x y =
        ((List.sort x), (List.sort y))

    let private totalDifferences list1 list2 =
        let rec loop left right total =
            match left, right with
            | [], _
            | _, [] -> total
            | h1::t1, h2::t2 ->
                loop t1 t2 (total + abs(h2 - h1))
        (loop list1 list2 0)
        
    let solve =
        let (x, y) = listsFromFile (getAbsoluteContentPath "input/day1.txt")
        if List.length x <> List.length y
        then raise (ArgumentException "The input lists must be the same length")
        else
            sortLists x y
            |> fun (sorted1, sorted2) -> totalDifferences sorted1 sorted2
        