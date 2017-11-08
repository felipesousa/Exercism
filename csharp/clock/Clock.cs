using System;

public struct Clock : IEquatable<Clock>
{
    const int MINUTES_IN_HOUR = 60;
    const int HOURS_IN_DAY = 24;
    const int MINUTES_IN_DAY = MINUTES_IN_HOUR * HOURS_IN_DAY;

    public Clock(int hours, int minutes)
    {
        var totalMinutes = TotalMinutes(hours, minutes);
        Hours = totalMinutes / MINUTES_IN_HOUR;
        Minutes = totalMinutes - (Hours * MINUTES_IN_HOUR);
    }

    public int Hours { get; private set; }

    public int Minutes { get; private set; }

    public Clock Add(int minutesToAdd) =>
        new Clock(Hours, Minutes + minutesToAdd);

    public Clock Subtract(int minutesToSubtract) =>
        new Clock(Hours, Minutes - minutesToSubtract);

    public override string ToString() => $"{Hours:00}:{Minutes:00}";

    public override bool Equals(object obj)
    {
        if(!(obj is Clock)) return false;
        return Equals((Clock)obj);
    }

    public override int GetHashCode() =>
        TotalMinutes(Hours, Minutes).GetHashCode();

    static int TotalMinutes(int hours, int minutes)
    {
        var totalMinutes = hours * MINUTES_IN_HOUR + minutes;

        // Roll over for the day
        totalMinutes = totalMinutes % MINUTES_IN_DAY;

        // Roll over for the previous day
        if(totalMinutes < 0) totalMinutes += MINUTES_IN_DAY;

        return totalMinutes;
    }

    public bool Equals(Clock other) =>
        TotalMinutes(Hours, Minutes) == TotalMinutes(other.Hours, other.Minutes);
}