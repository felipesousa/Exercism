using System;
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
        if(Valid())
        {
            return Parse();
        }
        return 0;
    }

    private bool Valid()
    {
        return !Regex.Match( _value, "[^0-2]" ).Success;
    }

    private int Parse()
    {
        int value = 0;
        var reverse = new string(_value.Reverse().ToArray());
        for ( int i = 0; i < reverse.Length; i++ )
        {
            int digit = IntegerValue( reverse[i] );
            value += digit * (int)Math.Pow( 3, i );
        }
        return value;
    }

    private int IntegerValue( char c )
    {
        return c - '0';
    }
}