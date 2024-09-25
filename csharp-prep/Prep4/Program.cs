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
        foreach (int number in numbers)
    // iterate through the list to adda  sum
    }
}