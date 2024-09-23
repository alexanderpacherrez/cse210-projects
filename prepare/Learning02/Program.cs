using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._company = "MTC";
        job1._jobTitle = "Trainer";
        job1._startYear = 2023;
        job1._endYear = 2025;

        Job job2 = new Job ();
        job2._company = "ASPERSUD";
        job2._jobTitle = "CEO";
        job2._startYear = 2019;
        job2._endYear = 2032;

        Resume myResume = new Resume();
        myResume._name = "Alexander Pacherrez";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}