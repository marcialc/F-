


module HelloSquare

let square x = x * x

[<EntryPoint>]
let main argv = 
    printfn "%d square is: %d!" 15 (square 15)
    0 // return an integer exit code
