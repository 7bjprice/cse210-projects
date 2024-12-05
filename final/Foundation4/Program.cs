using System;

class Program
{
    // attributes
    static List<Activity> _activites = new List<Activity>{};
    static void Main(string[] args)
    {
        Activity run1 = new Run(5, "05 December 2024", 40);
        _activites.Add(run1);

        Activity bike1 = new Bike(25, "06 December 2024", 60);
        _activites.Add(bike1);

        Activity swim1 = new Swim(15, "07 December 2024", 30);
        _activites.Add(swim1);

        foreach (Activity a in _activites)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}