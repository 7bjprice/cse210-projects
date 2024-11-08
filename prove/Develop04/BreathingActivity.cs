class BreathingActivity : Activity
{
    // attributes
    private int _numBreaths;

    // methods
    public BreathingActivity()
    {
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _activityName = "Breathing Activity";
    }

    public int CalcBreaths()
    {
        return _durationSeconds / 10;
    }

    public override void StartActivity()
    {
        base.StartActivity();
        _numBreaths = CalcBreaths();
        int remainingTime = _durationSeconds - (_numBreaths * (6 + 4));

        for (int i = 0; i < _numBreaths; i++)
        {
            DisplayInhale(6);
            DisplayExhale(4);
        }


        if (remainingTime > 0)
        {
            Console.WriteLine("Completing with a final partial breath.");
            DisplayInhale(Math.Min(6, remainingTime));
            remainingTime -= Math.Min(6, remainingTime);

            if (remainingTime > 0)
            {
                DisplayExhale(remainingTime);
            }
        }

    }

    public void DisplayInhale(int duration)
    {
        Console.Write("Breathe in...");
        for (int i = duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void DisplayExhale(int duration)
    {
        Console.Write("Breathe out...");
        for (int i = duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
