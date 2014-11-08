using System;
using System.Collections.Generic;

public static class AccumulateExtensions
{
    public static IEnumerable<T2> Accumulate<T1, T2>(this IEnumerable<T1> source, Func<T1, T2> operation )
    {
        foreach (var item in source)
        {
            yield return operation(item);
        }
    }
}
