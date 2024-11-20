class ChecklistGoal : Goal
{
    // attributes
    private int _totalProgress;

    private int _bonus;

    // methods
        public ChecklistGoal(string title, string description, int pointValue, int totalProgress, int bonus, bool isComplete=false, int progress=0) : base(pointValue, title, description, progress)
    {
        _pointValue = pointValue;
        _title = title;
        _description = description;
        _isComplete = isComplete;
        _bonus = bonus;
        _progress = progress;
        _totalProgress = totalProgress;
    }

    public void IncrementProgress()
    {
        _progress++;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public override void DisplayGoal()
    {
        if (_isComplete == false)
            Console.WriteLine($"[ ] {_title} ({_description}) -- Currently Completed: {_progress}/{_totalProgress}");
        else
            Console.WriteLine($"[X] {_title} ({_description}) -- Currently Completed: {_progress}/{_totalProgress}");
    }

    public int GetTotalProgress()
    {
        return _totalProgress;
    } 

    public override void WriteGoal(string filename)
    {
        // ensures user enters a valid filename
        if (string.IsNullOrEmpty(filename))
        {
            throw new ArgumentException("Filename cannot be null or empty.", nameof(filename));
        }

        //appends goal onto existing file
        using (StreamWriter outputFile = new StreamWriter(filename, false))
        {
            outputFile.WriteLine($"ChecklistGoal|{_title}|{_description}|{_pointValue}|{_progress}|{_totalProgress}|{_isComplete}|{_bonus}");
        }
    }
}