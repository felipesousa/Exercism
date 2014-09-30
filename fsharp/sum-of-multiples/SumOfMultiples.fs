module SumOfMultiples

open System.Collections.Generic
open System.Linq

type SumOfMultiples(baseMultiples) =         

    member s.To value = 
        let multiples = seq { for i in 1..(value - 1) do if s.multipleOf i then yield i }
        multiples |> Seq.sum
    
    member s.multipleOf value =
        baseMultiples |> Seq.exists( fun multiple -> value % multiple = 0 )

    new () = SumOfMultiples([3; 5])