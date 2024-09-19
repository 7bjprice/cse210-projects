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
    }
}