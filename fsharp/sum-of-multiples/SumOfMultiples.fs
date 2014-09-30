module SumOfMultiples

open System.Collections.Generic
open System.Linq

type SumOfMultiples(baseMultiples) =         
    
    let multipleOf value =
        baseMultiples |> Seq.exists( fun multiple -> value % multiple = 0 )

    member s.To value = 
        seq { 1..(value - 1) }
        |> Seq.filter multipleOf
        |> Seq.sum

    new () = SumOfMultiples([3; 5])