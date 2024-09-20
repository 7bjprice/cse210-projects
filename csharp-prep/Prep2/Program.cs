using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string percent = Console.ReadLine();
        int grade = int.Parse(percent);
        if (grade >= 90)
        {
            Console.WriteLine("A");
        }

        else if (80 <= grade)
        {
            Console.WriteLine("B");
        }

        else if (70 <= grade)
        {
            Console.WriteLine("C");
        }

        else if (60 <= grade)
        {
            Console.WriteLine("D");
        }

        else Console.WriteLine("F");

        if (grade >= 70)
        {
            Console.WriteLine("You passed the class!");
        }

        else Console.WriteLine("You failed the class. Better luck next time!");
    }
}