public class Activity
{
   // Core activity properties
   protected string _description;
   protected string _activityName;
   protected int _durationSeconds;
   protected int _totalDuration = 0;

   // Gets desired duration from user input
   public int GetDuration()
   {
       Console.Write("How long, in seconds, would you like your session to last? ");
       return int.Parse(Console.ReadLine());
   }

   // Displays a simple loading animation
   public void ShowAnimation(int length=2)
   {
       List<string> animations = new List<string> {"/", "-", "\\","|"};
        for (int i = length / 2; i > 0; i--)   
           foreach (string s in animations)
           {
               Console.Write(s);
               Thread.Sleep(500);
               Console.Write("\b \b");
           }
   }

   public void GetReady()
   {
       Console.WriteLine("Get ready...");
       ShowAnimation();
   }

   // Starts activity with welcome message and duration setup
   public virtual void StartActivity()
   {
       Console.Clear();
       Console.WriteLine($"Welcome to the {_activityName}!");
       Console.WriteLine();
       Console.WriteLine(_description);
       _durationSeconds = GetDuration();
       Console.Clear();
       GetReady();
   }

   // Concludes activity and shows summary
   public void EndActivity()
   {
       Console.WriteLine("Good job!");
       _totalDuration += _durationSeconds;
       ShowAnimation();
       Console.WriteLine($"You have completed another {_durationSeconds} seconds of the {_activityName} for a total of {_totalDuration} seconds!");
   }
}