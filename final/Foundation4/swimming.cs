using System;

public class Swimming : Activity
{
    private int _laps;

    // Constructor to initialize the swimming activity with date, duration, and laps
    public Swimming(DateTime date, double minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    // Override method to get the distance of the swimming activity
    public override double GetDistance()
    {
        return (_laps * 50) / 1000 * 0.62;
    }
}