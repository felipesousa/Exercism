using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SumOfMultiples
{
    private readonly IEnumerable<int> _baseMultiples;

    /// <summary>
    /// Configures the class with the base multiples 3 and 5.
    /// </summary>
    public SumOfMultiples()
    {
        _baseMultiples = new[] {3, 5};
    }

    /// <summary>
    /// Configures the class with a set of base multiples.
    /// </summary>
    public SumOfMultiples(IEnumerable<int> baseMultiples)
    {
        _baseMultiples = baseMultiples;
    }

    public int To(int to)
    {
        List<int> multiples = new List<int>();
        foreach(int baseMultiple in _baseMultiples)
        {
            var found =  Multiples
                            .Range(baseMultiple, to, baseMultiple)
                            .Where(i => !multiples.Contains(i));
            multiples.AddRange(found);
        }
        return multiples.Sum();
    }
}

public static class Multiples
{
    /// <summary>
    /// A version of Enumerable.Range that takes an increment value
    /// </summary>
    /// <param name="start">The first number to return</param>
    /// <param name="stop">The exclusive max value</param>
    /// <param name="increment">The amount to increment by</param>
    /// <returns></returns>
    public static IEnumerable<int> Range(int start, int stop, int increment)
    {
        for(int i = start; i < stop; i += increment)
            yield return i;
    }
}
