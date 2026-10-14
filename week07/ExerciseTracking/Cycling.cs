using System;

public class Cycling : Activity
{
    private int _speed;

    //Cycling is the name for the field _activityName
    public Cycling (int speed, string date, int lengthMinutes) :base(date, lengthMinutes, "Cycling")
    {
        _speed = speed;
    }


    public override double GetDistance()
    {
        return _speed* (GetMinutes()/60.0) ; 
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return GetMinutes()/GetDistance() ;
    }
}