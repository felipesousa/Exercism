using System;
using System.Runtime.Remoting.Messaging;
using System.Text;
using NUnit.Framework;

[TestFixture]
public class RomanNumeralsTest
{
    // Change 'Ignore = true' to 'Ignore = false' to run a test case.
    // You can also just remove 'Ignore = true'.

    [TestCase(0, Result = "")]
    [TestCase(1, Result = "I")]
    [TestCase(2, Result = "II")]
    [TestCase(3, Result = "III")]
    [TestCase(4, Result = "IV")]
    [TestCase(5, Result = "V")]
    [TestCase(6, Result = "VI")]
    [TestCase(9, Result = "IX")]
    [TestCase(27, Result = "XXVII")]
    [TestCase(48, Result = "XLVIII")]
    [TestCase(59, Result = "LIX")]
    [TestCase(93, Result = "XCIII")]
    [TestCase(141, Result = "CXLI")]
    [TestCase(163, Result = "CLXIII")]
    [TestCase(402, Result = "CDII")]
    [TestCase(575, Result = "DLXXV")]
    [TestCase(911, Result = "CMXI")]
    [TestCase(1024, Result = "MXXIV")]
    [TestCase(3000, Result = "MMM")]
    public string Convert_roman_to_arabic_numerals(int arabicNumeral)
    {
        return arabicNumeral.ToRoman();
    }
}

public static class IntegerExtensions
{
    public static String ToRoman( this int n )
    {
        var result = new StringBuilder( );
        while ( n >= 1000 )
        {
            result.Append( "M" );
            n -= 1000;
        }
        if ( n >= 900 )
        {
            result.Append( "CM" );
            n -= 900;
        }

        if ( n >= 500 )
        {
            result.Append( "D" );
            while ( n >= 600 )
            {
                result.Append( "C" );
                n -= 100;
            }
            n -= 500;
        }
        if ( n >= 400 )
        {
            result.Append( "CD" );
            n -= 400;
        }
        while ( n >= 100 )
        {
            result.Append( "C" );
            n -= 100;
        }
        if ( n >= 90 )
        {
            result.Append( "XC" );
            n -= 90;
        }

        if(n >= 50)
        {
            result.Append("L");
            while(n >= 60)
            {
                result.Append("X");
                n -= 10;
            }
            n -= 50;
        }
        if(n >= 40)
        {
            result.Append("XL");
            n -= 40;
        }
        while(n >= 10)
        {
            result.Append("X");
            n -= 10;
        }
        if(n >= 9)
        {
            result.Append("IX");
            n -= 9;
        }

        if(n >= 5)
        {
            result.Append("V");
            while(n >= 6)
            {
                result.Append("I");
                n -= 1;
            }
            n -= 5;
        }
        if(n >= 4)
        {
            result.Append("IV");
            n -= 4;
        }
        while(n >= 1)
        {
            result.Append("I");
            n -= 1;
        }

        return result.ToString();
    }
}