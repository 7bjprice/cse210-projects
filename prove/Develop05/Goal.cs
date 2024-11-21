using System.ComponentModel;

abstract class Goal
{
    // Attributes common to all types of goals
    protected int _pointValue;       // Points associated with the goal
    protected string _title;         // Title or name of the goal
    protected bool _isComplete;      // Indicates whether the goal is completed
    protected string _description;   // Short description of the goal
    protected int _progress;         // Tracks progress toward completing the goal

    // Constructor to initialize a goal with default or provided values
    public Goal(int pointValue, string title, string description, int progress = 0)
    {
        _pointValue = pointValue;
        _title = title;
        _isComplete = false;         // Goals are incomplete by default
        _description = description;
        _progress = progress;
    }

    // Getter methods to retrieve goal properties
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

    // Returns the current progress of the goal (can be overridden)
    public virtual int GetProgress()
    {
        return _progress;
    }

    // Marks the goal as completed
    public void SetIsComplete()
    {
        _isComplete = true;
    }

    // Abstract methods to be implemented by derived classes
    // Displays goal details to the user
    public abstract void DisplayGoal();

    // Writes the goal's data to a file
    public abstract void WriteGoal(string filename = "goals.txt");
}
