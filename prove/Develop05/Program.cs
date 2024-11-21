using System;
using System.Net.Quic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

// Creativity:
// Added an option to remove a goal from the list
// Added multiple print statements notifying user that functions were successful
// Added an auto save feature that will save to the last used filename
// Added a negative Goal feature, when completed points are subtracted.

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
                else if (line.StartsWith("ChecklistGoal|"))
                {
                    goals.Add(new ChecklistGoal(goalArray[1], goalArray[2], int.Parse(goalArray[3]), int.Parse(goalArray[5]), int.Parse(goalArray[7]), bool.Parse(goalArray[6]), int.Parse(goalArray[4])));
                }
                else if (line.StartsWith("NegativeGoal|"))
                {
                    goals.Add(new NegativeGoal(goalArray[1], goalArray[2], int.Parse(goalArray[3]), int.Parse(goalArray[4])));
                }
                else if (line.StartsWith("SCORE|"))
                {
                    _points = int.Parse(goalArray[1]);
                }
            }
        }
        
        return goals;
    }

    static void WriteScore(string filename, int points)
    {
        // ensures user enters a valid filename
        if (string.IsNullOrEmpty(filename))
        {
            throw new ArgumentException("Filename cannot be null or empty.", nameof(filename));
        }

        //appends goal onto existing file
        using (StreamWriter outputFile = new StreamWriter(filename, false))
        {
            outputFile.WriteLine($"SCORE|{points}");
        }
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine($"\nYou have {_points} points.\n");

            // Display menu options for the user
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Create New Goal");
            Console.WriteLine("    2. List Goals");
            Console.WriteLine("    3. Save Goal");
            Console.WriteLine("    4. Load Goal");
            Console.WriteLine("    5. Record Goal");
            Console.WriteLine("    6. Remove goal");
            Console.WriteLine("    7. Quit");
            Console.Write("Select a choice from the menu: ");

            _userInput = int.Parse(Console.ReadLine());

            switch (_userInput)
            {
                case 1:
                    while (true)
                    {
                        Console.WriteLine("The goal types are:");
                        Console.WriteLine("    1. Eternal Goal");
                        Console.WriteLine("    2. Simple Goal");
                        Console.WriteLine("    3. Checklist Goal");
                        Console.WriteLine("    4. Negative Goal");
                        Console.Write("Which type of goal would you like to create? ");
                        _userInput = int.Parse(Console.ReadLine());

                        Console.Write("What is the name of your goal? ");
                        string title = Console.ReadLine();
                        Console.Write("What is a short description of it? ");
                        string description = Console.ReadLine();
                        Console.Write("What is the amount of points associated with this goal? ");
                        int pointvalue = int.Parse(Console.ReadLine());

                        switch (_userInput)
                        {
                            case 1:
                                EternalGoal myEternalGoal = new EternalGoal(pointvalue, title, description);
                                goals.Add(myEternalGoal);
                                Console.WriteLine("Goal successfully created!");
                                break;
                            case 2:
                                SimpleGoal mySimpleGoal = new SimpleGoal(pointvalue, title, description);
                                goals.Add(mySimpleGoal);
                                Console.WriteLine("Goal successfully created!");
                                break;
                            case 3:
                                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                                int totalprogress = int.Parse(Console.ReadLine());
                                Console.Write("What is the bonus for accomplishing it this many times? ");
                                int bonus = int.Parse(Console.ReadLine());
                                ChecklistGoal myChecklistGoal = new ChecklistGoal(title, description, pointvalue, totalprogress, bonus);
                                goals.Add(myChecklistGoal);
                                Console.WriteLine("Goal successfully created!");
                                break;
                            case 4:
                                NegativeGoal myNegativeGoal = new NegativeGoal(title, description, pointvalue);
                                goals.Add(myNegativeGoal);
                                Console.WriteLine("Goal successfully created!");
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
                    Console.WriteLine("Your Goals:");
                    if (goals.Count() != 0)
                    {
                        foreach (Goal g in goals)
                        {
                            Console.Write($"    {i}. ");
                            g.DisplayGoal();
                            i++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("There are no goals to display!");
                    }
                    break;

                case 3:
                    Console.Write("Enter a filename to save to: ");
                    _filename = Console.ReadLine();
                    if (string.IsNullOrEmpty(_filename))
                    {
                        throw new ArgumentException("Filename cannot be null or empty.", nameof(_filename));
                    }
                    string defaultfile = _filename;
                    WriteScore(_filename, _points);
                    foreach (Goal g in goals)
                    {
                        g.WriteGoal(_filename);
                    }
                    Console.WriteLine("Goals successfully saved!");
                    break;

                case 4:
                    Console.Write("Enter filename to retrieve from: ");
                    string filename1 = Console.ReadLine();
                    if (string.IsNullOrEmpty(filename1))
                    {
                        throw new ArgumentException("Filename cannot be null or empty.", nameof(filename1));
                    }
                    goals = ReadGoals(filename1);
                    Console.WriteLine($"{goals.Count()} goals were successfully loaded.");
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
                    Console.Write("Your choice: ");
                    _userInput = int.Parse(Console.ReadLine());
                    Goal SelectedGoal = goals[_userInput-1];
                    if (!(SelectedGoal is NegativeGoal))
                    {
                        Console.WriteLine($"Congratulations! You have earned {SelectedGoal.GetPointValue()} points!");
                    }
                    else
                    {
                        Console.WriteLine($"Shame on you! You have lost {Math.Abs(SelectedGoal.GetPointValue())} points.");
                    }

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
                            Console.WriteLine($"You earned a bonus of {checklistGoal.GetBonus()} points!");
                            checklistGoal.SetIsComplete();
                        }
                    }
                    else if (SelectedGoal is NegativeGoal negativeGoal)
                    {
                        negativeGoal.IncrementProgress();
                    }
                    else
                    {
                        SelectedGoal.SetIsComplete();
                    };
                    break;

                case 6:
                    Console.WriteLine("Which goal would you like to remove? ");
                    int k = 1;
                    foreach (Goal g in goals)
                    {
                        Console.Write($"{k}. ");
                        g.DisplayGoal();
                        k++;
                    }
                    Console.Write("Your choice: ");
                    _userInput = int.Parse(Console.ReadLine());
                    goals.RemoveAt(_userInput-1);
                    Console.WriteLine("Goal successfully removed!");
                    break;

                case 7: // Quit the application
                    WriteScore(defaultfile="goals.txt", _points);
                    foreach (Goal g in goals)
                    {
                        g.WriteGoal(defaultfile="goals.txt");
                    }
                    Console.WriteLine("Goals saved!");
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
