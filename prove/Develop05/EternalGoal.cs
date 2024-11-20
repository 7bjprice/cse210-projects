class EternalGoal : Goal
{
    // attributes

    // methods
    public EternalGoal(int pointValue, string title, string description, int progress=0) : base(pointValue, title, description)
    {
        _progress = 0;
        _pointValue = pointValue;
        _title = title;
        _description = description;
        _isComplete = false;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[x{_progress}] {_title} ({_description})");
    }

    public void IncrementProgress()
    {
        _progress++;
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
            outputFile.WriteLine($"EternalGoal|{_title}|{_description}|{_pointValue}|{_progress}");
        }
    }
}