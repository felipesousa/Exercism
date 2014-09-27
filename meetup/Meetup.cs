using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Meetup
{
    public Meetup(int month, int year)
    {
    }

    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        return DateTime.Now;
    }
}

public enum Schedule
{
    First,
    Second,
    Third,
    Fourth,
    Last,
    Teenth
}