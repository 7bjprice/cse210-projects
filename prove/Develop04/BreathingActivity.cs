class BreathingActivity : Activity
{
   private int _numBreaths;

   public BreathingActivity()
   {
       _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
       _activityName = "Breathing Activity";
   }

   // Calculates number of complete breath cycles based on duration
   public int CalcBreaths()
   {
       return _durationSeconds / 10;
   }

   public override void StartActivity()
   {
       base.StartActivity();
       _numBreaths = CalcBreaths();
       int remainingTime = _durationSeconds - (_numBreaths * (6 + 4));

       // Run complete breath cycles
       for (int i = 0; i < _numBreaths; i++)
       {
           DisplayInhale(6);
           DisplayExhale(4);
       }

       // Use any remaining time for partial breath cycle
       if (remainingTime > 0)
       {
           DisplayInhale(remainingTime * 3/5);
           DisplayExhale(remainingTime * 2/5);
       }
   }

   // Displays countdown for inhale portion
   public void DisplayInhale(int duration)
   {
       Console.Write("Breathe in...");
       for (int i = duration; i > 0; i--)
       {
           Console.Write(i);
           Thread.Sleep(1000);
           Console.Write("\b \b");
       }
       Console.WriteLine();
   }

   // Displays countdown for exhale portion
   public void DisplayExhale(int duration)
   {
       Console.Write("Breathe out...");
       for (int i = duration; i > 0; i--)
       {
           Console.Write(i);
           Thread.Sleep(1000);
           Console.Write("\b \b");
       }
       Console.WriteLine();
   }
}