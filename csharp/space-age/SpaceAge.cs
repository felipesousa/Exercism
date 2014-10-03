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
        return Decimal.Round(OnEarthAccurate / MERCURY_YEAR, 2);
    }

    public decimal OnVenus()
    {
        return Decimal.Round(OnEarthAccurate / VENUS_YEAR, 2);
    }

    public decimal OnMars()
    {
        return Decimal.Round(OnEarthAccurate / MARS_YEAR, 2);
    }

    public decimal OnJupiter()
    {
        return Decimal.Round(OnEarthAccurate / JUPITER_YEAR, 2);
    }

    public decimal OnSaturn()
    {
        return Decimal.Round(OnEarthAccurate / SATURN_YEAR, 2);
    }

    public decimal OnUranus()
    {
        return Decimal.Round(OnEarthAccurate / URANUS_YEAR, 2);
    }

    public decimal OnNeptune()
    {
        return Decimal.Round(OnEarthAccurate / NEPTUNE_YEAR, 2);
    }

    private decimal OnEarthAccurate { get { return Seconds / EARTH_YEAR; } }
}
