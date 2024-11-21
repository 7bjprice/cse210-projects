class SimpleGoal : Goal
{
    // Represents a goal that can be completed once and marked as done

    // Constructor to initialize a SimpleGoal with its properties
    public SimpleGoal(int pointValue, string title, string description, bool isComplete = false) 
        : base(pointValue, title, description)
    {
        _pointValue = pointValue;   // Points earned upon completion
        _title = title;             // Title or name of the goal
        _description = description; // Short description of the goal
        _isComplete = isComplete;   // Indicates whether the goal has been completed
    }

    // Displays the goal in a readable format, showing its completion status
    public override void DisplayGoal()
    {
        if (_isComplete == false)
            Console.WriteLine($"[ ] {_title} ({_description})");
        else
            Console.WriteLine($"[X] {_title} ({_description})");
        // Example outputs:
        // - Incomplete: "[ ] Finish homework (Complete today's assignments)"
        // - Complete: "[X] Finish homework (Complete today's assignments)"
    }

    // Writes the goal's details to a specified file
    public override void WriteGoal(string filename)
    {
        // Validate that the filename is not null or empty
        if (string.IsNullOrEmpty(filename))
        {
            throw new ArgumentException("Filename cannot be null or empty.", nameof(filename));
        }

        // Append the SimpleGoal details to the file in a specific format
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            outputFile.WriteLine($"SimpleGoal|{_title}|{_description}|{_pointValue}|{_isComplete}");
            // Format: "SimpleGoal|<Title>|<Description>|<PointValue>|<IsComplete>"
        }
    }
}
