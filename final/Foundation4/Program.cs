using System;
using System.Collections.Generic;

namespace FitnessTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var activities = new List<Activity>
            {
                new Running(new DateTime(2025, 7, 20), 30, 3.0),
                new Cycling(new DateTime(2025, 7, 19), 45, 12.0),
                new Swimming(new DateTime(2025, 7, 18), 25, 20)
            };

            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}
