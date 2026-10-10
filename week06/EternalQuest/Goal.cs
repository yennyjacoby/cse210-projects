using System;

// Abstract will allow define methodes that MUST be overridden
public abstract class Goal 
{
    private string _name;
    private string _description;
    private int _points;
    private bool _isComplete;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }
    
    public string GetName() => _name;
    public string GetDescription() => _description;
    public int GetPoints() => _points;
    public bool IsComplete() => _isComplete;

    protected void MarkComplete()
    {
        _isComplete = true;
    }

//Abstract method to be override by other classes
    public abstract void RecordEvent();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();

}