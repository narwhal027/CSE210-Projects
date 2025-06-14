using System;
using System.Threading;

namespace MindfulnessApp
{
    public abstract class MindfulnessActivity
    {
        protected string _activityName;
        protected string _description;
        protected int _duration; // seconds

        protected MindfulnessActivity(string name, string description)
        {
            _activityName = name;
            _description = description;
        }

        public void Run()
        {
            DisplayStartingMessage();
            PerformActivity();
            DisplayEndingMessage();
        }

        private void DisplayStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_activityName}.");
            Console.WriteLine(_description);
            Console.Write("Enter duration in seconds: ");
            while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
                Console.Write("Please enter a positive integer for duration: ");
            Console.WriteLine("\nGet ready...");
            ShowPauseAnimation(3);
        }


        private void DisplayEndingMessage()
        {
            Console.WriteLine("\nGreat job!");
            ShowPauseAnimation(2);
            Console.WriteLine($"\nYou have completed the {_activityName} for {_duration} seconds.");
            ShowPauseAnimation(3);
        }

        protected void ShowPauseAnimation(int seconds)
        {
            var spinner = new[] { '|', '/', '-', '\\' };
            var endTime = DateTime.Now.AddSeconds(seconds);
            int idx = 0;
            while (DateTime.Now < endTime)
            {
                Console.Write(spinner[idx++ % spinner.Length]);
                Thread.Sleep(200);
                Console.Write("\b");
            }
            Console.Write(" ");
            Console.Write("\b");
            Console.WriteLine();
        }

        protected void ShowCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
        }

        protected abstract void PerformActivity();
    }
}
