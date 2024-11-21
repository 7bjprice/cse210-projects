class NegativeGoal : Goal
{
    // attributes

    // methods
    public NegativeGoal(string title, string description, int pointValue, int progress=0) : base(pointValue, title, description)
    {
        _title = title;
        _description = description;
        _pointValue = pointValue;
        _progress = progress;
        _isComplete = false; 
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[x{_progress}] {_title} ({_description})");
    }

    public override void WriteGoal(string filename)
    {
        // ensures user enters a valid filename
        if (string.IsNullOrEmpty(filename))
        {
            throw new ArgumentException("Filename cannot be null or empty.", nameof(filename));
        }

        //appends goal onto existing file
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            outputFile.WriteLine($"NegativeGoal|{_title}|{_description}|{_pointValue}|{_progress}");
        }
    }
    
    public void IncrementProgress()
    {
        _progress++;
    }
}