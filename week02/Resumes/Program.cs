using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._company = "Metaneoe";
        job1._jobTitle = "Software Developer";
        job1._startYear = 2023;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._company = "Atos";
        job2._jobTitle = "Support 1NI";
        job2._startYear = 2023;
        job2._endYear = 2023;


        Resume myResume = new Resume("Hallan Miranda");

        myResume.jobs.Add(job1);
        myResume.jobs.Add(job2);

        myResume.Display();
    }
}