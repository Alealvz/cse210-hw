using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2023, 5, 3), 90, 3),
            new Cycling(new DateTime(2023, 5, 4), 60, 15),
            new Swimming(new DateTime(2023, 5, 5), 20, 5)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}