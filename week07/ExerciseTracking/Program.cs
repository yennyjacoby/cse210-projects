using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Cycling cycling = new Cycling(15, "02 October 2026", 25);
        Running running = new Running(10, "01 October 2026", 40);
        Swimming swimming = new Swimming(8, "03 October 2026", 10);

        List<Activity> activities = new List<Activity>();

        activities.Add(cycling);
        activities.Add(running);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}