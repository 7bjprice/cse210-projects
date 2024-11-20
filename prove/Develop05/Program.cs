using System;
using System.Net.Quic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    // Field to store the user's menu selection
    static int _userInput;

    static int _points = 0;

    static List<Goal> goals = new List<Goal>();

    static string _filename;

    // methods

    static List<Goal> ReadGoals(string filename)
    {
        List<Goal> goals = new List<Goal>();
        
        using (StreamReader sr = new StreamReader(filename))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] goalArray = line.Split("|");

                if (line.StartsWith("EternalGoal|"))
                {    
                    goals.Add(new EternalGoal(int.Parse(goalArray[3]), goalArray[1], goalArray[2], int.Parse(goalArray[4])));
                }
                else if (line.StartsWith("SimpleGoal|"))
                {
                    goals.Add(new SimpleGoal(int.Parse(goalArray[3]), goalArray[1], goalArray[2], bool.Parse(goalArray[4])));
                }
                else
                {
                    goals.Add(new ChecklistGoal(goalArray[1], goalArray[2], int.Parse(goalArray[3]), int.Parse(goalArray[5]), int.Parse(goalArray[7]), bool.Parse(goalArray[6]), int.Parse(goalArray[4])));
                }
            }
        }
        
        return goals;
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine($"You have {_points} points.\n");

            // Display menu options for the user
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Create New Goal");
            Console.WriteLine("    2. List Goals");
            Console.WriteLine("    3. Save Goal");
            Console.WriteLine("    4. Load Goal");
            Console.WriteLine("    5. Record Goal");
            Console.WriteLine("    6. Quit");
            Console.Write("Select a choice from the menu: ");

            _userInput = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (_userInput)
            {
                case 1:
                    while (true)
                    {
                        Console.WriteLine("The goal types are:");
                        Console.WriteLine("    1. Eternal Goal");
                        Console.WriteLine("    2. Simple Goal");
                        Console.WriteLine("    3. Checklist Goal");
                        Console.Write("Which type of goal would you like to create? ");
                        _userInput = int.Parse(Console.ReadLine());

                        Console.Write("What is the name of your goal? ");
                        string title = Console.ReadLine();
                        Console.Write("What is a short description of it? ");
                        string description = Console.ReadLine();
                        Console.Write("What is the amount of _points associated with this goal? ");
                        int pointvalue = int.Parse(Console.ReadLine());

                        switch (_userInput)
                        {
                            case 1:
                                EternalGoal myEternalGoal = new EternalGoal(pointvalue, title, description);
                                goals.Add(myEternalGoal);
                                break;
                            case 2:
                                SimpleGoal mySimpleGoal = new SimpleGoal(pointvalue, title, description);
                                goals.Add(mySimpleGoal);
                                break;
                            case 3:
                                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                                int totalprogress = int.Parse(Console.ReadLine());
                                Console.Write("What is the bonus for accomplishing it this many times? ");
                                int bonus = int.Parse(Console.ReadLine());
                                ChecklistGoal myChecklistGoal = new ChecklistGoal(title, description, pointvalue, totalprogress, bonus);
                                goals.Add(myChecklistGoal);
                                break;
                            default:
                                Console.WriteLine("Invalid option. Press any button to continue.");
                                Console.ReadLine();
                                Console.Clear();
                                continue;  
                        }
                        break;
                    }
                    break;

                case 2:
                    int i = 1;
                    foreach (Goal g in goals)
                    {
                        Console.Write($"{i}. ");
                        g.DisplayGoal();
                        i++;
                    }
                    break;

                case 3:
                    Console.Write("Enter a filename to save to: ");
                    _filename = Console.ReadLine();
                    string defaultfile = _filename;
                    foreach (Goal g in goals)
                    {
                        g.WriteGoal(_filename);
                    }
                    break;

                case 4:
                    Console.Write("Enter filename to retrieve from: ");
                    string filename1 = Console.ReadLine();
                    goals = ReadGoals(filename1);
                    break;

                case 5:
                    Console.WriteLine("Which goal did you accomplish? ");
                    int j = 1;
                    foreach (Goal g in goals)
                    {
                        Console.Write($"{j}. ");
                        g.DisplayGoal();
                        j++;
                    }
                    _userInput = int.Parse(Console.ReadLine());
                    Goal SelectedGoal = goals[_userInput-1];
                    Console.WriteLine($"Congratulations! You have earned {SelectedGoal.GetPointValue()} points!");
                    _points += SelectedGoal.GetPointValue();

                    if (SelectedGoal is EternalGoal eternalGoal)
                    {
                        eternalGoal.IncrementProgress();
                    }

                    else if (SelectedGoal is ChecklistGoal checklistGoal)
                    {
                        checklistGoal.IncrementProgress();
                        if( checklistGoal.GetProgress() == checklistGoal.GetTotalProgress())
                        {
                            _points += checklistGoal.GetBonus();
                            checklistGoal.SetIsComplete();
                        }
                    }
                    else
                    {
                        SelectedGoal.SetIsComplete();
                    }
                    Console.WriteLine($"You now have {_points} _points.");
                    break;

                case 6: // Quit the application
                    foreach (Goal g in goals)
                    {
                        g.WriteGoal(defaultfile="goals.txt");
                    }
                    return;

                default: // Handle invalid input
                    Console.WriteLine("Invalid option. Press any button to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
            }
        }
    }
}
