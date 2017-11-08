using System;

public struct Clock
{
    public Clock(int hours, int minutes)
    {
        Hours = hours;
        Minutes = minutes;
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