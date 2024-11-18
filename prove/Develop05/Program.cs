using System;
using System.Net.Quic;

class Program
{
    // Field to store the user's menu selection
    static int _userInput;

    static void Main(string[] args)
    {

        while (true)
        {
            // Display menu options for the user
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Create New Goal");
            Console.WriteLine("    2. List Goals");
            Console.WriteLine("    3. Save Goal");
            Console.WriteLine("    4. Load Goal");
            Console.WriteLine("    5. Record Goal");
            Console.WriteLine("    6. Quit");

            _userInput = int.Parse(Console.ReadLine());

            switch (_userInput)
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;

                case 6: // Quit the application
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
