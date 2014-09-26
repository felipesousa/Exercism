using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SumOfMultiples
{
    private readonly IEnumerable<int> _bases;

    /// <summary>
    /// Configures the class with the base multipliers 3 and 5.
    /// </summary>
    public SumOfMultiples()
    {
        _bases = new[] {3, 5};
    }

    /// <summary>
    /// Configures the class with a set of base multipliers.
    /// </summary>
    public SumOfMultiples(IEnumerable<int> bases)
    {
        _bases = bases;
    }

    public int To(int to)
    {
        int sum = 0;
        IList<int> multiples = new List<int>();
        foreach(int @base in _bases)
        {
            for(int i = @base; i < to; i += @base )
            {
                if(!multiples.Contains(i))
                {
                    sum += i;
                    multiples.Add(i);
                }
            }
        }
        return sum;
    }
}
