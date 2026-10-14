using System;

public class Running : Activity
{
    private int _distance;

    public Running (int distance, string date, int lengthMinutes):base(date, lengthMinutes, "Running")
    {
        _distance = distance;
    }


    public override double GetDistance()
    {
        return _distance; 
    }

    public override double GetSpeed()
    {
        return GetDistance()/GetMinutes()*60;
    }

    public override double GetPace()
    {
        return GetMinutes()/GetDistance();
    }
}