using System;

public class Swimming : Activity
{
    private double _laps;

    public Swimming (double laps, string date, int lengthMinutes):base(date, lengthMinutes, "Swimming")
    {
        _laps = laps;
    }


    public override double GetDistance()
    {
        return _laps * 50/1000; 
    }

    public override double GetSpeed()
    {
        return GetDistance() / GetMinutes()*60 ;
    }

    public override double GetPace()
    {
        return GetMinutes()/ GetDistance();
    }
}