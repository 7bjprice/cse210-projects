using System;
using System.Net.Quic;

// Creativity Requirements: I added a feature that allows the user to see the total time spent on each activity. After an activity is completed it displays the total time that the user has spent in a given activity. Another feature I added, in the Breathing exersise accounts for when a user enters a duration that is not divisible by a breath length. It will display a short breathing exercise to accomodate to their desired time limit.

class Program
{
    // Field to store the user's menu selection
    static int _userInput;

    static void Main(string[] args)
    {
        // Instantiate different activity types to manage specific activity sessions
        Activity currentActivity = new();
        BreathingActivity breathe = new();
        ReflectionActivity reflect = new();
        ListingActivity listing = new();

        while (true)
        {
            // Display menu options for the user
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Start Breathing Activity");
            Console.WriteLine("    2. Start Reflection Activity");
            Console.WriteLine("    3. Start Listing Activity");
            Console.WriteLine("    4. Quit");

            _userInput = int.Parse(Console.ReadLine());

            switch (_userInput)
            {
                case 1: // Start Breathing Activity
                    breathe.StartActivity();
                    breathe.EndActivity();
                    break;

                case 2: // Start Reflection Activity
                    reflect.StartActivity(); 
                    reflect.EndActivity(); 
                    break;

                case 3: // Start Listing Activity
                    listing.StartActivity();
                    listing.EndActivity();
                    break;

                case 4: // Quit the application
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
