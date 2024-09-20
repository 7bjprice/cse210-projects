using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string percent = Console.ReadLine();
        int grade = int.Parse(percent);
        string letter;
        if (grade >= 90)
        {
            letter = "A";
        }

        else if (80 <= grade)
        {
            letter = "B";
        }

        else if (70 <= grade)
        {
            letter = "C";
        }

        else if (60 <= grade)
        {
            letter = "D";
        }

        else letter = "F";

        if (grade >= 70)
        {
            Console.WriteLine($"Your grade: {letter}. You passed the class!");
        }

        else Console.WriteLine($"Your grade: {letter}. You failed the class. Better luck next time!");
    }
}