namespace AoC24

open System

module public Day1 =
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
        
    let solve x y =
        if List.length x <> List.length y
        then raise (ArgumentException "The input lists must be the same length")
        else
            sortLists x y
            |> fun (sorted1, sorted2) -> totalDifferences sorted1 sorted2
        