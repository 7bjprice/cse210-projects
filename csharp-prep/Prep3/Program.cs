using System;

class Program
{
    static void Main(string[] args)
    {
        int play_again = 1;
        do
        {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);
        int total_guesses = 0;

        while (true)
        {
        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int guess_number = int.Parse(guess);
        if (guess_number < number)
        {
            Console.WriteLine("    Too low!");
            total_guesses ++;
        }
        else if (guess_number > number)
        {
            Console.WriteLine("    Too high!");
            total_guesses++;
        }
        else 
        {
            Console.WriteLine("You guessed it!");
            total_guesses ++;
            Console.WriteLine($"It took you {total_guesses} guesses.\n");
            Console.Write("Would you like to play again (yes/no)? ");
            string restart = Console.ReadLine();
            if (restart == "yes")
            {
                play_again = 1;
                break;
            }
            else
            {
                play_again = 0;
                break; 
            }
        }
        }
        } while (play_again == 1);
    }
}