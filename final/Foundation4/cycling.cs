using System;

public class Cycling : Activity
{
    private double _speed;

    // Constructor to initialize the cycling activity with date, duration, and speed
    public Cycling(DateTime date, double minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
    }

    // Override method to get the distance of the cycling activity
    public override double GetDistance()
    {
        return (_speed * base.GetPace()) / 60;
    }

    // Override method to get the speed of the cycling activity
    public override double GetSpeed()
    {
        return _speed;
    }
}