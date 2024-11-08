class ListingActivity : Activity
{
    // attributes
    private int _count;
    private string _prompt;

    // methods

    public ListingActivity()
    {
        _activityName = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
    public string GetRandPrompt()
    {
        List<string> prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
           " Who are some of your personal heroes?"
        };

        Random rand = new Random();
        return prompts[rand.Next(prompts.Count())];
    }

    public void DisplayPrompt()
    {
        _prompt = GetRandPrompt();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {_prompt} ---");
        Console.WriteLine("You may begin in:");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
        Console.WriteLine();
    }

    public string GetResponse()
    {
        return Console.ReadLine();
    }

    public int CountResponse()
    {
        return _count;
    }

    public override void StartActivity()
    {
        base.StartActivity();
        DisplayPrompt();
        GetReady();

        DateTime start = DateTime.Now;
        while ((DateTime.Now - start).TotalSeconds < _durationSeconds)
        {
            Console.Write(">");
            Console.ReadLine();
            _count++;
        }
        Console.WriteLine($"You listed {_count} items!");

    }
}