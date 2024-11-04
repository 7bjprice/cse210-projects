class ReflectionActivity : Activity
{
    // attributes
    private List<string> _listPrompts;

    private string _currentPrompt;

    // methods
    public ReflectionActivity()
    {
        _activityName = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        _listPrompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
    }
    public string GetRandPrompt()
    {
        Random rand = new Random();
        return _listPrompts[rand.Next(_listPrompts.Count)];
    }

    public void DisplayPrompt()
    {
        _currentPrompt = GetRandPrompt();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {_currentPrompt} ---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    public void DisplaySubPrompt()
    {
        List<string> SubPrompts = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        Random rand = new Random();
        string SubPrompt = SubPrompts[rand.Next(SubPrompts.Count)];
        Console.Write($"\n> {SubPrompt} ");
        ShowAnimation();
    }
}