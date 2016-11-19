open System

let fibonacci n =
  let rec f a b n =
    match n with
    | 0 -> a
    | 1 -> b
    | n -> (f b (a + b) (n - 1))
  f (bigint 0) (bigint 1) n

[<EntryPoint>]
let main argv = 
    printf "Enter a positive integer: "
    // assume user enters valid input
    let inputNumber = Console.ReadLine() |> int32 
    printf "Fibonacci number: %A" (fibonacci inputNumber)
    0 // return an integer exit code
