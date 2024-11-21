class EternalGoal : Goal
{
    // Represents a goal that can be completed multiple times without ever being fully "completed"

    // Constructor to initialize the EternalGoal with its properties
    public EternalGoal(int pointValue, string title, string description, int progress = 0) 
        : base(pointValue, title, description)
    {
        _progress = 0;           // Eternal goals start with no progress
        _pointValue = pointValue; // Points earned each time the goal is completed
        _title = title;          // Title or name of the goal
        _description = description; // Short description of the goal
        _isComplete = false;     // Eternal goals are never marked as fully "complete"
    }

    // Displays the goal in a readable format
    public override void DisplayGoal()
    {
        Console.WriteLine($"[x{_progress}] {_title} ({_description})");
        // Example output: "[x5] Read a book chapter (Read 1 chapter daily)"
    }

    // Increments the progress count each time the goal is achieved
    public void IncrementProgress()
    {
        _progress++;
    }

    // Writes the goal details to a specified file
    public override void WriteGoal(string filename)
    {
        // Validate that the filename is not null or empty
        if (string.IsNullOrEmpty(filename))
        {
            throw new ArgumentException("Filename cannot be null or empty.", nameof(filename));
        }

        // Append the EternalGoal details to the file in a specific format
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            outputFile.WriteLine($"EternalGoal|{_title}|{_description}|{_pointValue}|{_progress}");
            // Format: "EternalGoal|<Title>|<Description>|<PointValue>|<Progress>"
        }
    }
}
