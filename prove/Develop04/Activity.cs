public class Activity
{
    // attributes
    protected string _description;
    protected string _activityName;
    protected int _durationSeconds;

    //methods
    public int GetDuration()
    {
        Console.Write("How long, in seconds, would you like your session to last? ");
        return int.Parse(Console.ReadLine());

    }

    public void ShowAnimation()
    {
        List<string> animations = new List<string> {"/", "-", "\\","|"};
         for (int i = 2; i > 0; i--)   
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

    public void EndActivity()
    {
        Console.WriteLine("Good job!");
        ShowAnimation();
        Console.WriteLine($"You have completed another {_durationSeconds} seconds of the {_activityName}!");
    }

}