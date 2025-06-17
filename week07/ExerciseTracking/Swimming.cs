using System;
public class Swimming : Activity
{
    private double _numberLaps;

    public Swimming(string tipe, string date, double minutes, double numberLaps) : base(tipe, date, minutes)
    {
        _numberLaps = numberLaps;
    }
    public override double CreateDistance()
    {
        return _numberLaps * 50 / 1000;
    }
    public override double CreateSpeed()
    {
        return CreateDistance() / GetMinutes() * 60;
    }
    public override double CreatePace()
    {
        return GetMinutes() / CreateDistance();
    }
}