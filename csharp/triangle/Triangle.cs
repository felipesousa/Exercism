using System;

public class Triangle
{
    private readonly decimal _a, _b, _c;

    /// <summary>
    /// Initializes a new instance of the <see cref="Triangle"/> class.
    /// </summary>
    /// <param name="a">The first side</param>
    /// <param name="b">The second side</param>
    /// <param name="c">The third side</param>
    /// <exception cref="TriangleException">Thrown if this is not a valid triangle</exception>
    public Triangle( decimal a, decimal b, decimal c )
    {
        if(!Valid(a, b, c)) throw new TriangleException();
        _a = a;
        _b = b;
        _c = c;
    }

    /// <summary>
    /// Gets what kind of triangle this is
    /// </summary>
    public TriangleKind Kind()
    {
        if(IsEquilateral()) return TriangleKind.Equilateral;
        if(IsIsosceles())   return TriangleKind.Isosceles;
        return TriangleKind.Scalene;
    }

    private static bool Valid(decimal a, decimal b, decimal c)
    {
        return a + b > c && b + c > a && a + c > b;
    }

    private bool IsEquilateral()
    {
        return _a == _b && _b == _c;
    }

    private bool IsIsosceles()
    {
        return _a == _b || _b == _c || _a == _c;
    }
}

/// <summary>
/// Thrown for invalid triangles
/// </summary>
public class TriangleException : Exception
{
    public TriangleException()
        : base("Invalid triangle")
    {
    }
}

public enum TriangleKind
{
    /// <summary>A triangle with all sides equal</summary>
    Equilateral,
    /// <summary>A triangle with two sides equal</summary>
    Isosceles,
    /// <summary>A triangle with no sides equal</summary>
    Scalene
}