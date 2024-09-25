using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = 1;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string user_entry;
            user_entry = Console.ReadLine();
            number = int.Parse(user_entry);
            numbers.Add(number);
        }
        float total = 0;
        int max = 0;
        foreach (int i in numbers)
        {
            total = i + total;
            if (i >= max)
            {
                max = i;
            }
        }
        float average = total / (numbers.Count - 1);
        Console.WriteLine($"Total: {total}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}