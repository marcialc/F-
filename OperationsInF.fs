

module Operations

let divide x = x / 2

let multiply y = y * 2

let rec fib n =
    match n with
    | 1 | 2 -> 1
    | n -> fib(n-1) + fib(n-2)
 
[<EntryPoint>]

let main argv =

    printfn "Hello World"

    printfn "%d divided by 2 is: %d" 10 (divide 10)

    printfn "%d multiplied by 2 is: %d" 5 (multiply 5)

    printfn "%d in Fibonacci is:  %d" 8 (fib 8)


    0 // return an integer exit code
