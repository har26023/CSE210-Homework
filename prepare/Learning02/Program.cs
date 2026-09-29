using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "AI Engineer";
        job1._company = "Apple";
        job1._startYear = 2020;
        job1._endYear = 2026;

        Job job2 = new Job();
        job2._jobTitle = "Data Scientist";
        job2._company = "IBM";
        job2._startYear = 1990;
        job2._endYear = 1999;

        job1.Display();
        job2.Display();

        Resume myResume = new Resume();
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._name = "Malachi Harris";
        myResume.Display();
    }
}