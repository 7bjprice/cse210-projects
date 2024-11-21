class SimpleGoal : Goal
{
    // attributes

    // methods
    public SimpleGoal(int pointValue, string title, string description, bool isComplete=false) : base(pointValue, title, description)
    {
        _pointValue = pointValue;
        _title = title;
        _description = description;
        _isComplete = isComplete;
    }

    public override void DisplayGoal()
    {
        if (_isComplete == false)
            Console.WriteLine($"[ ] {_title} ({_description})");
        else
            Console.WriteLine($"[X] {_title} ({_description})");
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
            outputFile.WriteLine($"SimpleGoal|{_title}|{_description}|{_pointValue}|{_isComplete}");
        }
    }
}