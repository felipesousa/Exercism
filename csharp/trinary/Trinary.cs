using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Trinary
{
    private readonly string _value;

    public Trinary(string value)
    {
        _value = value;
    }

    public int ToDecimal()
    {
        if(IsInvalid()) return 0;
        return Parse();
    }

    private bool IsInvalid()
    {
        return Regex.Match(_value, "[^0-2]").Success;
    }

    private int Parse()
    {
        return _value.Reverse()
                     .Select(IntegerValue)
                     .Select(Base3ToBase10)
                     .Sum();
    }

    private int IntegerValue(char c)
    {
        return c - '0';
    }

    private int Base3ToBase10(int digit, int place)
    {
        return digit * (int)Math.Pow(3, place);
    }
}

//public static class StringExtensions
//{
//    public static string Reverse( this string text )
//    {
//        return new string(((IEnumerable<char>)text).Reverse().ToArray());
//    }
//}