using System;

public class Triangle
{
    private readonly decimal _a;
    private readonly decimal _b;
    private readonly decimal _c;

    public Triangle( decimal a, decimal b, decimal c )
    {
        _a = a;
        _b = b;
        _c = c;
    }

    public TriangleKind Kind()
    {
        if (!Valid()) 
            throw new TriangleException();
        if(IsEquilateral()) 
            return TriangleKind.Equilateral;
        if(IsIsosceles()) 
            return TriangleKind.Isosceles;
        return TriangleKind.Scalene;
    }

    private bool Valid()
    {
        return _a + _b > _c && _b + _c > _a && _a + _c > _b;
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