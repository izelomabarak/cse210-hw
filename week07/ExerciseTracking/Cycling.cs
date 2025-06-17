using System;
public class Cycling : Activity
{
    private double _speed;

    public Cycling(string tipe, string date, double minutes, double speed) : base(tipe, date, minutes)
    {
        _speed = speed;
    }
    public override double CreateDistance()
    {
        return _speed * GetMinutes() / 60;
    }
    public override double CreateSpeed()
    {
        return _speed;
    }
    public override double CreatePace()
    {
        return 60 / _speed;
    }
}