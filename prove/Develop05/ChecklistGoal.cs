class ChecklistGoal : Goal
{
    // Represents a goal that requires multiple completions to be considered complete, with a bonus reward upon completion

    // Attributes
    private int _totalProgress; // Total number of completions required for the goal
    private int _bonus;         // Bonus points awarded when the goal is fully completed

    // Constructor to initialize a ChecklistGoal with its properties
    public ChecklistGoal(string title, string description, int pointValue, int totalProgress, int bonus, bool isComplete = false, int progress = 0) 
        : base(pointValue, title, description, progress)
    {
        _pointValue = pointValue;   // Points earned for each completion
        _title = title;             // Title or name of the goal
        _description = description; // Short description of the goal
        _isComplete = isComplete;   // Indicates whether the goal has been fully completed
        _bonus = bonus;             // Bonus points awarded upon full completion
        _progress = progress;       // Tracks current number of completions
        _totalProgress = totalProgress; // Total completions required for full completion
    }

    // Increments the progress count each time the goal is completed
    public void IncrementProgress()
    {
        _progress++;
    }

    // Returns the bonus points awarded upon full completion
    public int GetBonus()
    {
        return _bonus;
    }

    // Displays the goal in a readable format, including progress and completion status
    public override void DisplayGoal()
    {
        if (_isComplete == false)
            Console.WriteLine($"[ ] {_title} ({_description}) -- Currently Completed: {_progress}/{_totalProgress}");
        else
            Console.WriteLine($"[X] {_title} ({_description}) -- Currently Completed: {_progress}/{_totalProgress}");
        // Example outputs:
        // - Incomplete: "[ ] Read 5 books (Read one book each week) -- Currently Completed: 2/5"
        // - Complete: "[X] Read 5 books (Read one book each week) -- Currently Completed: 5/5"
    }

    // Returns the total completions required for full completion
    public int GetTotalProgress()
    {
        return _totalProgress;
    }

    // Writes the goal's details to a specified file
    public override void WriteGoal(string filename)
    {
        // Validate that the filename is not null or empty
        if (string.IsNullOrEmpty(filename))
        {
            throw new ArgumentException("Filename cannot be null or empty.", nameof(filename));
        }

        // Append the ChecklistGoal details to the file in a specific format
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            outputFile.WriteLine($"ChecklistGoal|{_title}|{_description}|{_pointValue}|{_progress}|{_totalProgress}|{_isComplete}|{_bonus}");
            // Format: "ChecklistGoal|<Title>|<Description>|<PointValue>|<Progress>|<TotalProgress>|<IsComplete>|<Bonus>"
        }
    }
}
