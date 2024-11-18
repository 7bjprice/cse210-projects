using System.ComponentModel;

abstract class Goal
{
    // attributes
    protected int _pointValue;

    protected string _title;

    protected bool _isComplete;

    protected string _description;

    // methods

    public Goal(int pointValue, string title, string description)
    {
        _pointValue = pointValue;
        _title = title;
        _isComplete = false;
        _description = description;
    }

    public string GetTitle()
    {
        return _title;
    }

    public int GetPointValue()
    {
        return _pointValue;
    }

    public bool GetIsComplete()
    {
        return _isComplete;
    }

    public string GetDescription()
    {
        return _description;
    }


}