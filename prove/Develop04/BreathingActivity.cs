class BreathingActivity : Activity
{

    // attributes
    private int _numBreaths;

    // methods
    public BreathingActivity()
    {
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _activityName = "Breathing Activity";
    }

    public int CalcBreaths()
    {
        return _durationSeconds / 1000 ;
    }

    public void StartActivity()
    {
        _numBreaths = CalcBreaths();
        for (int i = 0; i < _numBreaths; i++)
        {
            DisplayInhale();
            DisplayExhale();
        }
    }

    public void DisplayInhale()
    {
        Console.WriteLine("Breathe in...\n");
        for (int i = 6; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
    }

    public void DisplayExhale()
    {
        Console.WriteLine("Breathe out...\n");
        for (int i = 4; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
    }

}