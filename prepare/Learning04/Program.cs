using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        Console.Write("What book are you reading? ");
        string book = Console.ReadLine();
        Console.Write("What class is that for? ");
        string topic = Console.ReadLine();
        Console.Write("What are your homework problems? ");
        string problems = Console.ReadLine();
        Console.Write("What section of the textbook is that? ");
        string textbooksection = Console.ReadLine();
        Console.Write("What class is that for? ");
        string mathclass = Console.ReadLine();
       MathAssignment math = new(textbooksection, problems, name, mathclass);
       WritingAssignment writing = new(book, name, topic);
       Console.WriteLine(math.GetSummary());
       Console.WriteLine(math.GetHomeworkList());
       Console.WriteLine(writing.GetSummary());
       Console.WriteLine(writing.GetWritingInformation());
    }
}