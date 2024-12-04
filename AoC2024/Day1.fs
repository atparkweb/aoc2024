namespace AoC24

open System

module public Day1 =
    let private sortLists x y =
        ((List.sort x), (List.sort y))

    let private totalDifferences list1 list2 =
        let rec loop left right total =
            match left, right with
            | [], _ -> total
            | _, [] -> total
            | h1::t1, h2::t2 ->
                loop t1 t2 (total + abs(h2 - h1))
        if List.length list1 <> List.length list2 then
            raise (ArgumentException "The input lists must be the same length")
        else
            (loop list1 list2 0)
        
    let solve (x: int list, y: int list) =
        let (sorted1, sorted2) = sortLists x y
        totalDifferences sorted1 sorted2
        