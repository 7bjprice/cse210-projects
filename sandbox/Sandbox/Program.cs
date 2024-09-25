using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        static int AwesomeFunction(int x)
        {
            return 4 * x + 3;
        }
        Console.Write("Enter an integer: ");
        string x_string = Console.ReadLine();
        int x = int.Parse(x_string);
        int y = AwesomeFunction(x);
        Console.WriteLine(y);
    }
}