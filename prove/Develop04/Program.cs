using System;
using System.Net.Quic;

class Program
{
    static int _userInput;

    static void Main(string[] args)
    {
        Activity currentActivity = new();
        while (true)
        {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("    1. Start Beathing Activity");
        Console.WriteLine("    2. Start Reflection Activity");
        Console.WriteLine("    3. Start Listing Activity");
        Console.WriteLine("    4. Quit");
        _userInput = int.Parse(Console.ReadLine());

            switch (_userInput)
            {
                case 1:
                    currentActivity = new BreathingActivity();
                    break;

                case 2:
                    currentActivity = new ReflectionActivity();
                    break;

                case 3:
                    currentActivity = new ListingActivity(); 
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Invalid choice. Press any key to continue.");
                    Console.ReadLine();
                    continue;
            }
            currentActivity.BeginActivity();
            currentActivity.StartActivity();
            currentActivity.EndActivity();

        }
    }
}