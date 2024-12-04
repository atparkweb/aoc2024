namespace AoC24

module public Day2 =
    let private MAX_CHANGE = 3

    let private isOrdered report =
        let ascending = Array.sort(report)
        ascending = report || ascending = Array.rev report
        
    let private isLevelSafe report =
        let rec loop items =
            match items with
                | []
                | [_] -> true
                | h :: t ->
                    let change = abs(h - t.[0])
                    if (change = 0 || change > MAX_CHANGE) then
                        false
                    else
                        loop t
        loop (Array.toList report)
        
    let private isSafe report =
        (isOrdered report) && (isLevelSafe report)

    let solve (input: int[][]) =
        input
        |> Array.filter isSafe
        |> Array.length