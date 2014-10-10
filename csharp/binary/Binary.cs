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
        return _binary.Reverse()
                      .Select((c, i) => c == '1' ? 1 << i : 0)
                      .Sum();
    }

    private static bool IsValid(string binary)
    {
        return !Regex.Match(binary, "[^01]").Success;
    }
}