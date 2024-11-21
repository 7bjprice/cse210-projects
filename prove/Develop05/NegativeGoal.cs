class NegativeGoal : Goal
{
    // Represents a goal that deducts points when completed

    // Constructor to initialize a NegativeGoal object with its attributes
    public NegativeGoal(string title, string description, int pointValue, int progress = 0) 
        : base(pointValue, title, description)
    {
        _title = title;            // Title of the goal
        _description = description; // Short description of the goal
        _pointValue = pointValue;  // Points deducted when this goal is completed
        _progress = progress;      // Tracks how many times this goal has been completed
        _isComplete = false;       // Negative goals are not inherently "completed"
    }

    // Displays the goal in a user-friendly format
    public override void DisplayGoal()
    {
        Console.WriteLine($"[x{_progress}] {_title} ({_description})");
        // Example output: "[x2] Avoid Junk Food (Avoid eating junk food for better health)"
    }

    // Saves the goal's details to a file
    public override void WriteGoal(string filename)
    {
        // Validate that the filename is not null or empty
        if (string.IsNullOrEmpty(filename))
        {
            throw new ArgumentException("Filename cannot be null or empty.", nameof(filename));
        }

        // Append the goal details to the specified file
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            outputFile.WriteLine($"NegativeGoal|{_title}|{_description}|{_pointValue}|{_progress}");
            // Format: "NegativeGoal|<Title>|<Description>|<PointValue>|<Progress>"
        }
    }

    // Increments the progress counter for this goal
    public void IncrementProgress()
    {
        _progress++;
    }
}
