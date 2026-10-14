using System;

public abstract class Activity
{
    private string _date;
    private int _lengthMinutes;
    private string _activityName;

    public Activity(string date, int lengthMinutes, string activityName)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
        _activityName = activityName;

    }



    public string GetDate() => _date;
    public int GetMinutes() => _lengthMinutes;

// the parent class showing the "virtual" keyword
//Abstract methods must NOT have { }.
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string  GetSummary()
    {
        return $"{_date} {_activityName} ({_lengthMinutes} min) - {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
    
}