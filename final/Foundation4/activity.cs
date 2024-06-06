using System;

public class Activity
{
    private DateTime _date;
    private double _minutes;

    // Constructor to initialize the activity with date and duration in minutes
    public Activity(DateTime date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // Virtual method to get the distance of the activity
    public virtual double GetDistance()
    {
        return 0.0;
    }

    // Virtual method to get the speed of the activity
    public virtual double GetSpeed()
    {
        return (GetDistance() / _minutes) * 60;
    }

    // Virtual method to get the pace of the activity
    public virtual double GetPace()
    {
        return _minutes / GetDistance();
    }

    // Method to get the summary of the activity
    public virtual string GetSummary()
    {
        return $"{_date.ToShortDateString()} Activity ({_minutes} min): Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace {GetPace():0.0} min per mile";
    }
}