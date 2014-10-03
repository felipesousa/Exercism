using System;

/// <summary>
/// Calculates the date that someone turned or will celebrate their 1 Gs anniversary.
/// </summary>
public class Gigasecond
{
    private static readonly double GIGASECOND = 1E9;
    private readonly DateTime _birthday;

    /// <summary>
    /// Initializes a new instance of the <see cref="Gigasecond"/> class.
    /// </summary>
    /// <param name="birthday">The day the person was born.</param>
    public Gigasecond(DateTime birthday)
    {
        _birthday = birthday;
    }

    /// <summary>
    /// The date of the person's Gigasecond birthday
    /// </summary>
    /// <returns></returns>
    public DateTime Date()
    {
        return _birthday.AddSeconds( GIGASECOND ).Date;
    }
}
