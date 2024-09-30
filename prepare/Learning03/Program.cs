using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new();
        job1._jobTitle = "Computer Engineer";
        job1._company = "IBM";
        job1._startYear = 2020;
        job1._endYear = 2024;

    Job job2 = new();
        job2._jobTitle = "Software Engineer";
        job2._company = "Apple";
        job2._startYear = 2015;
        job2._endYear = 2020;

        Resume myresume = new();
        myresume._name = "Bryson Price";
        myresume._jobs.Add(job1);
        myresume._jobs.Add(job2);

       myresume.DisplayJobDetails();

    }
}