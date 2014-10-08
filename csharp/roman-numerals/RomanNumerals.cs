using System;
using System.Collections.Generic;
using System.Text;

public static class RomanNumerals
{
    // The roman numerals for various numeric values
    private static readonly Dictionary<int, char> _numerals = new Dictionary<int, char>( )
    {
        {1000, 'M'},
        { 500, 'D'},
        { 100, 'C'},
        {  50, 'L'},
        {  10, 'X'},
        {   5, 'V'},
        {   1, 'I'}
    };

    /// <summary>
    /// Converts a given number into a roman numeral
    /// </summary>
    public static String ToRoman( this int n )
    {
        if(n < 0 || n > 3899) throw new ArgumentException("The value must be a positive number less than or equal to 3899");
        var result = new StringBuilder();
        for ( int multiplier = 1000; multiplier >= 1; multiplier /= 10 )
            n = Parse(n, result, multiplier);

        return result.ToString();
    }

    /// <summary>
    /// Parses the specified integer into a roman numeral in the range .9 times the given multiplier
    /// through to 8 times the given multiplier. For example, 9 through 80 which translates to IX to LXXX.
    /// </summary>
    /// <param name="n">The number to parse</param>
    /// <param name="result">A StringBuilder to which roman numerals are added</param>
    /// <param name="multiplier">The multiplier.</param>
    /// <returns>The number decremented by the amount that was parsed out as roman numerals</returns>
    private static int Parse( int n, StringBuilder result, int multiplier )
    {
        // Handle 5 to 8, 50 to 80 or 500 to 800
        if ( n >= 5 * multiplier )
        {
            result.Append(_numerals[5 * multiplier]);

            // Handle 6 to 8, 60 to 80 or 600 to 800
            while(n >= 6 * multiplier)
            {
                result.Append(_numerals[multiplier]);
                n -= multiplier;
            }
            n -= 5 * multiplier;
        }
        // Handle 4, 40 or 400
        if(n >= 4 * multiplier)
        {
            result.Append(_numerals[multiplier]);
            result.Append( _numerals[5 * multiplier] );
            n -= 4 * multiplier;
        }
        // Handle 1 to 3, 10 to 30, 100 to 3000 or 1000 to 3000
        while(n >= multiplier)
        {
            result.Append(_numerals[multiplier]);
            n -= multiplier;
        }
        // Handle 9, 90 or 900
        if(n >= .9 * multiplier)
        {
            result.Append(_numerals[multiplier / 10]);
            result.Append(_numerals[multiplier]);
            n -= (int)(.9 * multiplier);
        }
        return n;
    }
}