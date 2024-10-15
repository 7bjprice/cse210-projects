using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction one_one = new();
        Fraction five_one = new(5);
        Fraction three_four = new(3 ,4);
        Fraction one_three = new(1, 3);
         
        Console.WriteLine(one_one.GetFractionString());
        Console.WriteLine(one_one.GetTop());
        Console.WriteLine(five_one.GetFractionString());
        Console.WriteLine(five_one.GetTop());
        Console.WriteLine(three_four.GetFractionString());
        Console.WriteLine(three_four.GetDecimalValue());
        Console.WriteLine(one_three.GetFractionString());
        Console.WriteLine(one_three.GetDecimalValue());
    }
}