namespace AoC24

open System
open System.Text.RegularExpressions

module public Day3 =
    let solve input =
        let pattern = Regex(@"mul\((\d+),(\d+)\)")
        let matches = pattern.Matches(input)
        let mutable total = 0
        for m in matches do
            let product =
                Int32.Parse(m.Groups.[1].Value) * Int32.Parse(m.Groups.[2].Value)
            total <- total + product
        total
