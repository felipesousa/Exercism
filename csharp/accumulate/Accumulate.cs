using System;
using System.Collections.Generic;

public static class AccumulateExtensions
{
    public static IEnumerable<T> Accumulate<T>(this IEnumerable<T> source, Func<T, T> operation )
    {
        foreach (var item in source)
        {
            yield return operation(item);
        }
    }
}
