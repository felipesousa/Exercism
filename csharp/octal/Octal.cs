using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Octal
{
    public static int ToDecimal(string value)
    {
        try
        {
            int result = 0;
            int len = value.Length;
            for(int i = 0; i < len; i++)
            {
                int oct = ParseOctalValue(value[len - i - 1]);
                result += oct * (int)Math.Pow(8, i);
            }
            return result;
        }
        catch(ArgumentException)
        {
            return 0;
        }
    }

    static int ParseOctalValue(char c)
    {
        if(c < '0' || c > '7')
            throw new ArgumentException("Must be 0 through 7", nameof(c));

        return c - '0';
    }
}
