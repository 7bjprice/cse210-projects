class ReflectionActivity : Activity
{
   private List<string> _listPrompts;
   private string _currentPrompt;
   private Random _random = new();

   public ReflectionActivity()
   {
       _activityName = "Reflection Activity";
       _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

       // Initial prompts to select experiences for reflection
       _listPrompts = new List<string>
       {
           "Think of a time when you stood up for someone else.",
           "Think of a time when you did something really difficult.",
           "Think of a time when you helped someone in need.",
           "Think of a time when you did something truly selfless."
       };
   }

   // Gets a random prompt from the list
   public string GetRandPrompt()
   {
       return _listPrompts[_random.Next(_listPrompts.Count)];
   }

   // Shows prompt and waits for user acknowledgment
   public void DisplayPrompt()
   {
       _currentPrompt = GetRandPrompt();
       Console.WriteLine("Consider the following prompt:");
       Console.WriteLine($"--- {_currentPrompt} ---");
       Console.WriteLine("When you have something in mind, press enter to continue.");
       Console.ReadLine();
   }

   public override void StartActivity()
   {
       base.StartActivity();
       DisplayPrompt();
       
       Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
       Console.Write("You may begin in: ");
       for (int i = 5; i > 0; i--)
       {
           Console.Write(i);
           Thread.Sleep(1000);
           Console.Write("\b \b");
       }

       // Show sub-prompts until time runs out
       DateTime startTime = DateTime.Now;
       while ((DateTime.Now - startTime).TotalSeconds < _durationSeconds)
       {
           DisplaySubPrompt();
       }
       Console.WriteLine();
   }

   // Shows follow-up questions with animation
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

       string SubPrompt = SubPrompts[_random.Next(SubPrompts.Count)];
       Console.Write($"\n> {SubPrompt} ");
       ShowAnimation(5);
   }
}