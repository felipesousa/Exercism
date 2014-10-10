using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Binary
{
    private readonly string _binary;

    public Binary(string binary)
    {
        _binary = IsValid(binary) ? binary : "0";
    }

    public int ToDecimal()
    {
        return _binary.Select( ( c, i ) => _binary[_binary.Length - i - 1] == '1' ? 1 : 0 )
                      .Select( ( digit, i ) => (int)Math.Pow(2, i) * digit )
                      .Sum();
    }

    private static bool IsValid(string binary)
    {
        return !Regex.Match(binary, "[^01]").Success;
    }
}