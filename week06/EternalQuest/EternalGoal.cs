using System;

//inherint from Goal
public class EternalGoal: Goal
{

    //calling the parent constructor
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }

    public override void RecordEvent()
    {
    }

    public override string GetDetailsString()
    {
        return $"[ ] {GetName()} ({GetDescription()})";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal: {GetName()}, {GetDescription()}, {GetPoints()}";
    }
}