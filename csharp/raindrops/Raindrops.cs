using System;
using System.Collections.Generic;
using System.Linq;

public static class Raindrops
{
    private static readonly IDictionary<int, string> rain = 
        new Dictionary<int, string>
        {
            { 3, "Pling" }, { 5, "Plang" }, { 7, "Plong" }
        };

    public static string Convert(int number)
    {
        var words = PrimeFactors(number)
                        .Where(n => rain.ContainsKey(n))
                        .Distinct()
                        .Select(i => rain[i])
                        .ToArray();
        return words.Any() ? String.Concat(words) : number.ToString();
    }

    private static IEnumerable<int> PrimeFactors(long i)
    {
        int factor = 2;
        while(i > 1)
        {
            while(i % factor != 0) factor++;
            i /= factor;
            yield return factor;
        }
    }
}