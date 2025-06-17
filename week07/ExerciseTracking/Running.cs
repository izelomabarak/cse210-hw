using System;
public class Running : Activity
{
    private double _distance;

    public Running(string tipe, string date, double minutes, double distance) : base(tipe, date, minutes)
    {
        _distance = distance;
    }
    public override double CreateDistance()
    {
        return _distance;
    }
    public override double CreateSpeed()
    {
        return _distance / GetMinutes() * 60;
    }
    public override double CreatePace()
    {
        return GetMinutes() / _distance;
    }
}