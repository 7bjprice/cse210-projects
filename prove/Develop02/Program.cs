// Added multiple different prompts that can be choses
// Added a message if there are no journal entries to display
// Added the time of day to the date stamp on each journal entry

class Program
{
    // Behaviors
    static void Main(string[] args)
    {
        bool exit = false;
        Journal Journal = new();
        Console.WriteLine("Welcome to your journal program!");
        do
        {
            Console.WriteLine("\nPlease choose what you would like to do.");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            string userSelection = Console.ReadLine();
            // Make a Journal obj
            if (userSelection == "1")
            {
                Journal.AddEntry();
            }
            else if (userSelection == "2")
            {
                Journal.DisplayEntries();
            }
            else if (userSelection == "3")
            {
                Journal.LoadFile();
            }
            else if (userSelection == "4")
            {
                Journal.SaveFile();
            }
            else
            {
                exit = true;
            }
        } while (!exit);
        Environment.Exit(0);
    }
}
