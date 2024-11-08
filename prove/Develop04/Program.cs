using System;
using System.Net.Quic;

class Program
{
    static int _userInput;

    static void Main(string[] args)
    {
        Activity currentActivity = new();
        BreathingActivity breathe = new();
        ReflectionActivity reflect = new();
        ListingActivity listing = new();
        while (true)
        {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("    1. Start Breathing Activity");
        Console.WriteLine("    2. Start Reflection Activity");
        Console.WriteLine("    3. Start Listing Activity");
        Console.WriteLine("    4. Quit");
        _userInput = int.Parse(Console.ReadLine());

            switch (_userInput)
            {
                case 1:
                    breathe.StartActivity();
                    breathe.EndActivity();
                    break;

                case 2:
                    reflect.StartActivity();
                    reflect.EndActivity();
                    break;

                case 3:
                    listing.StartActivity();
                    listing.EndActivity();
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Invalid option. Press any button to continue.");
                    Console.ReadLine();
                    continue;
            }
        }
    }
}