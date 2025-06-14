using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    public class ListingActivity : MindfulnessActivity
    {
        private readonly List<string> _prompts = new()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity()
            : base("Listing Activity",
                   "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        { }

        protected override void PerformActivity()
        {
            var rand = new Random();
            Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Count)]);
            Console.WriteLine("\nYou may begin in:");
            ShowCountdown(5);

            var entries = new List<string>();
            var endTime = DateTime.Now.AddSeconds(_duration);
            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                var input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                    entries.Add(input);
            }

            Console.WriteLine($"\nYou listed {entries.Count} items!");
        }
    }
}
