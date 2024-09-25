using System;

class Program
{
    static void Main(string[] args)
    {
    // DisplayWelcome - Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // PromptUserName - Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        string username = Console.ReadLine();
        return username;
    }

    // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite integer: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int x)
    {
        return x * x;
    }

    // DisplayResult - Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string username , int number)
    {
        Console.WriteLine($"{username}, the square of your number is {number}.");
    }
   
    DisplayWelcome();
    string name = PromptUserName();
    int number = PromptUserNumber();
    int SquaredNumber = SquareNumber(number);
    DisplayResult(name, SquaredNumber);
    }
}