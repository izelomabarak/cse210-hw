using System;

public abstract class Activity
{
    private string _tipe;
    private string _date;
    private double _minutes;

    public Activity(string tipe, string date, double minutes)
    {
        _tipe = tipe;
        _date = date;
        _minutes = minutes;
    }
    public string GetDate()
    {
        return _date;
    }
    public double GetMinutes()
    {
        return _minutes;
    }
    public string GetTipe()
    {
        return _tipe;
    }
    public string GetSummary()
    {
        return $"{GetDate()} {GetTipe()} ({GetMinutes()} min): Distance {CreateDistance().ToString("N2")} km, Speed: {CreateSpeed().ToString("N2")} kph, Pace: {CreatePace().ToString("N2")} min per km";
    }
    public abstract double CreateDistance();
    public abstract double CreateSpeed();
    public abstract double CreatePace();
}