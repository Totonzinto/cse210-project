using System;

public class Running : Activity
{
    private double _distance;

    // Constructor to initialize the running activity with date, duration, and distance
    public Running(DateTime date, double minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    // Override method to get the distance of the running activity
    public override double GetDistance()
    {
        return _distance;
    }
}