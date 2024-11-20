using System.ComponentModel;

abstract class Goal
{
    // attributes
    protected int _pointValue;

    protected string _title;

    protected bool _isComplete;

    protected string _description;

    protected int _progress;

    // methods

    public Goal(int pointValue, string title, string description, int progress=0)
    {
        _pointValue = pointValue;
        _title = title;
        _isComplete = false;
        _description = description;
        _progress = progress;
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

    public virtual int GetProgress()
    {
        return _progress;
    }

    public void SetIsComplete()
    {
        _isComplete = true;
    }

    public abstract void DisplayGoal();

    public abstract void WriteGoal(string filename);

}