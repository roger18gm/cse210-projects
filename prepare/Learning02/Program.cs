using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job("Microsoft", "Software Engineer", 2018, 2019);
        Job job2 = new Job("Apple", "App Developer", 2016, 2024);

        // job1.Display();
        // job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayJobs();
        // Console.WriteLine(myResume._jobs[1]._jobTitle);

    }
}