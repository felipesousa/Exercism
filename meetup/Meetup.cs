using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Aids in scheduling meetups
/// </summary>
public class Meetup
{
    private DateTime _startOfMonth;

    /// <summary>
    /// Initializes a new instance of the <see cref="Meetup"/> class.
    /// </summary>
    /// <param name="month">The month of the meetup.</param>
    /// <param name="year">The year of the meetup.</param>
    /// <exception cref="System.ArgumentException">
    /// Month must be between 1 and 12 inclusive
    /// and Year must be between 1 and 9999 inclusive
    /// </exception>
    public Meetup(int month, int year)
    {
        if (month < 1 || month > 12) throw new ArgumentException("Month must be between 1 and 12 inclusive");
        if (year < 1 || year > 9999) throw new ArgumentException("Year must be between 1 and 9999 inclusive");
        _startOfMonth = new DateTime(year, month, 1);
    }

    /// <summary>
    /// Calculates the day of the meetup
    /// </summary>
    /// <param name="dayOfWeek">The day of week.</param>
    /// <param name="schedule">The scheduled week of the meetup.</param>
    /// <returns>The date of the meetup.</returns>
    /// <exception cref="System.NotSupportedException"></exception>
    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        switch(schedule)
        {
            case Schedule.First:
            case Schedule.Second:
            case Schedule.Third:
            case Schedule.Fourth:
                return CalculateMeetup(dayOfWeek, schedule);
            case Schedule.Last:
                return CalculateLastWeekMeetup(dayOfWeek, schedule);
            case Schedule.Teenth:
                return CalculateTeenthMeetup(dayOfWeek, schedule);
            default:
                // Just in case someone adds a new enum in the future
                throw new NotSupportedException(string.Format("Schedule {0} is not supported", schedule));
        }
    }

    private DateTime CalculateMeetup(DayOfWeek dayOfWeek, Schedule schedule)
    {
        return FindDayInWeek(_startOfMonth.AddDays((int)schedule*7), dayOfWeek);
    }

    private DateTime CalculateLastWeekMeetup(DayOfWeek dayOfWeek, Schedule schedule)
    {
        return FindDayInWeek(_startOfMonth.AddMonths(1).AddDays(-7), dayOfWeek);
    }

    private DateTime CalculateTeenthMeetup(DayOfWeek dayOfWeek, Schedule schedule)
    {
        return FindDayInWeek(_startOfMonth.AddDays(12), dayOfWeek);
    }

    /// <summary>
    /// Checks the seven days of the given week to see if they are the
    /// correct day of the week.
    /// </summary>
    /// <param name="day">The first day of the week</param>
    /// <param name="dayOfWeek">The day of the week to find</param>
    /// <returns>The date found</returns>
    private DateTime FindDayInWeek(DateTime day, DayOfWeek dayOfWeek)
    {
        return (from i in Enumerable.Range(0, 7)
                where day.AddDays(i).DayOfWeek == dayOfWeek
                select day.AddDays(i)).FirstOrDefault();
    }
}

/// <summary>
/// The week of the month to schedule a meetup.
/// </summary>
public enum Schedule
{
    /// <summary>First week of the month</summary>
    First = 0,
    /// <summary>Second week of the month</summary>
    Second = 1,
    /// <summary>Third week of the month</summary>
    Third = 2,
    /// <summary>Fourth week of the month</summary>
    Fourth = 3,
    /// <summary>Last week of the month</summary>
    Last = 4,
    /// <summary>The days of the month that end in 'teenth'</summary>
    Teenth = 5
}