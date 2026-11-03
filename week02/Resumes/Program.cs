using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._jobTitle = "Nocturnal Operations Manager";
        job2._company = "jocinik co.";
        job2._startYear = 2022;
        job2._endYear = 2030;

        Resume myResume = new Resume();
        myResume._name = "Dalton J. Niklitschek";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}