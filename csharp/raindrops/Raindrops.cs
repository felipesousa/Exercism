using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Raindrops
{
    private const string PLING = "Pling";
    private const string PLANG = "Plang";
    private const string PLONG = "Plong";

    public static string Convert(int number)
    {
        var builder = new StringBuilder();
        foreach(var factor in PrimeFactors(number).Distinct())
        {
            switch(factor)
            {
                case 3:
                    builder.Append(PLING);
                    break;
                case 5:
                    builder.Append(PLANG);
                    break;
                case 7:
                    builder.Append(PLONG);
                    break;
            }
        }
        if(builder.Length == 0)
            builder.Append(number);

        return builder.ToString();
    }

    private static IEnumerable<long> PrimeFactors(long i)
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