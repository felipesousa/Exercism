using System;

public class SpaceAge
{
    public const decimal EARTH_YEAR   = 31557600;    // seconds
    public const decimal MERCURY_YEAR = 0.2408467m;  // Earth years
    public const decimal VENUS_YEAR   = 0.61519726m; // Earth years
    public const decimal MARS_YEAR    = 1.8808158m;  // Earth years
    public const decimal JUPITER_YEAR = 11.862615m;  // Earth years
    public const decimal SATURN_YEAR  = 29.447498m;  // Earth years
    public const decimal URANUS_YEAR  = 84.016846m;  // Earth years
    public const decimal NEPTUNE_YEAR = 164.79132m;  // Earth years

    public SpaceAge(ulong seconds)
    {
        Seconds = seconds;
    }

    public ulong Seconds { get; private set; }

    public decimal OnEarth()
    {
        return Decimal.Round(OnEarthAccurate, 2);
    }

    public decimal OnMercury()
    {
        return Calculate(MERCURY_YEAR);
    }

    public decimal OnVenus()
    {
        return Calculate(VENUS_YEAR);
    }

    public decimal OnMars()
    {
        return Calculate(MARS_YEAR);
    }

    public decimal OnJupiter()
    {
        return Calculate(JUPITER_YEAR);
    }

    public decimal OnSaturn()
    {
        return Calculate(SATURN_YEAR);
    }

    public decimal OnUranus()
    {
        return Calculate(URANUS_YEAR);
    }

    public decimal OnNeptune()
    {
        return Calculate(NEPTUNE_YEAR);
    }

    private decimal Calculate(decimal earthYears)
    {
        return Decimal.Round(OnEarthAccurate / earthYears, 2);
    }

    private decimal OnEarthAccurate { get { return Seconds / EARTH_YEAR; } }
}
