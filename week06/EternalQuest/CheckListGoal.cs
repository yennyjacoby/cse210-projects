using System;


public class CheckListGoal: Goal
{

    private int _amountCompleted;
    private int _target;
    private int _bonus;
    //calling the parent constructor
    public CheckListGoal(string name, string description, int points, int amountCompleted, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted= amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;

        if (_amountCompleted >= _target)
        {
            MarkComplete();
        }
    }
    public int GetBonus()
    {
        return _bonus;
    }


    public override string GetDetailsString()
    {
        string checkbox = IsComplete()? "[X]": "[ ]";
        return $"{checkbox} {GetName()} ({GetDescription()}) -- Completed {_amountCompleted}/{_target} times";

    }

    public override string GetStringRepresentation()
    {
        return $"CheckListGoal:{GetName()}|{GetDescription()}|{GetPoints()}|{_amountCompleted}|{_target}|{_bonus}|{IsComplete()}";

    }
}