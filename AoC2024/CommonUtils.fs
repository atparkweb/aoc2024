namespace AoC24

open System
open System.IO

module CommonUtils =
    let private getProjectRootDirectory () =
        let baseDir = AppDomain.CurrentDomain.BaseDirectory
        Directory.GetParent(baseDir).Parent.Parent.Parent.FullName
        
    let private getAbsoluteContentPath filePath =
        Path.Combine(getProjectRootDirectory(), filePath)

    (** <summary>
    Converts a text file containing two columns to two lists.
    Columns are delimited by spaces.
    </summary>
    <param name="filePath">The relative path to the text file. Relative to project directory</param>
    <returns>Two lists of equal length. Each item being a line in each column.</returns>
    *)
    let columnsFromFile filePath =
        let lines = File.ReadAllLines(getAbsoluteContentPath(filePath))
        let list1, list2 =
            lines
            |> Seq.fold (fun (left, right) line ->
                let parts = line.Split([|' '|], StringSplitOptions.RemoveEmptyEntries) |> List.ofArray
                let leftPart = int parts.[0]
                let rightPart = int parts.[1]
                (leftPart :: left, rightPart :: right)) ([], [])
        (List.rev list1, List.rev list2)
        
    (** <summary>
    Converts a text file containing integers on each line to an two-dimensional array of integers.
    </summary>
    <param name="filePath">The relative path to the text file. Relative to the project directory</param>
    <returns>An array of each line from the file. Each line converted to an array of integers.
    *)
    let numericalDataFromFile filePath =
        getAbsoluteContentPath(filePath)
        |> File.ReadAllLines
        |> Array.map (fun line -> (Array.map Int32.Parse (line.Split " ")))
