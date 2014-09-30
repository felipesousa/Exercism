module SumOfMultiples

open System.Collections.Generic
open System.Linq

type SumOfMultiples = 
    val baseMultiples : IEnumerable<int>

    new () = { baseMultiples = [3; 5] }

    new baseMultiples = { baseMultiples = baseMultiples }

    member this.To value = 
        this.multiplesOf(value) |> Seq.sum

    member private this.multiplesOf value:seq<int> =
        seq<int> { for i in 1..(value - 1) do if this.ismultiple i then yield i }

    member private this.ismultiple value =
        this.baseMultiples.Any(fun baseMultiple -> value % baseMultiple = 0)