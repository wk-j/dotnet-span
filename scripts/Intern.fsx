
open System

let a:string = "Hello, world!"
let b:string = "Hello, world!"

a = b |> printfn "%A"
obj.ReferenceEquals(a, b)   |> printfn "%A"


String.IsInterned("Hello, world!") |> printfn "%A"