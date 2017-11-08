using System;

public struct Clock
{
    const int MINUTES_IN_HOUR = 60;
    const int HOURS_IN_DAY = 24;
    const int MINUTES_IN_DAY = MINUTES_IN_HOUR * HOURS_IN_DAY;

    public Clock(int hours, int minutes)
    {
        var totalMinutes = hours * MINUTES_IN_HOUR + minutes;

        // Roll over for the day
        totalMinutes = totalMinutes % MINUTES_IN_DAY;

        Hours = totalMinutes / MINUTES_IN_HOUR;
        Minutes = totalMinutes - (Hours * MINUTES_IN_HOUR);
    }

    public int Hours { get; private set; }

    public int Minutes { get; private set; }

    public Clock Add(int minutesToAdd)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public Clock Subtract(int minutesToSubtract)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public override string ToString() => $"{Hours:00}:{Minutes:00}";
}