namespace AoC24

open System
open System.IO

module CommonUtils =
    let private getProjectRootDirectory () =
        let baseDir = AppDomain.CurrentDomain.BaseDirectory
        Directory.GetParent(baseDir).Parent.Parent.Parent.FullName
        
    let getAbsoluteContentPath filePath =
        Path.Combine(getProjectRootDirectory(), filePath)
