using System;
using System.Data.Common;

class Program
{
    // attributes
    static List<Event> _events = new List<Event>{};
    static void Main(string[] args)
    {
        Event lecture1 = new Lecture("Day One", "A lecture covering class policies", "12/6/2024", "11:30am", "Brigham Young", 60);
        lecture1.CreateAddress("123 Cherry Lane", "Rexburg", "ID");
        _events.Add(lecture1);

        Event reception1 = new Reception("Wedding", "Temple Sealing", "1/3/2025", "3:00pm", "30 Degress with snow");
        reception1.CreateAddress("50 S University Ave", "Provo", "UT");
        _events.Add(reception1);

        Event outdoor1 = new OutdoorGathering("Party", "A big party with food", "4/20/2025", "8:00pm", "7bjprice@gmail.com");
        outdoor1.CreateAddress("456 Blackberry Rd", "Rexburg", "ID");
        _events.Add(outdoor1);

        foreach (Event e in _events)
        {
            Console.WriteLine("\n");
            e.DisplayShortDescription();
            Console.WriteLine("..........................");
            e.DisplayStandardDetails();
            Console.WriteLine("..........................");
            if (e is Lecture l)
            {
                l.DisplayFullDetails();
            }
            else if (e is Reception r)
            {
                r.DisplayFullDetails();
            }
            else if (e is OutdoorGathering o)
            {
                o.DisplayFullDetails();
            }
            Console.WriteLine("\n");

        }



    }
}