using System;

namespace MindfulnessApp
{
    public class BreathingActivity : MindfulnessActivity
    {
        public BreathingActivity()
            : base("Breathing Activity",
                   "This activity will help you relax by walking you through breathing in and out slowly. " +
                   "Clear your mind and focus on your breathing.")
        { }

        protected override void PerformActivity()
        {
            var endTime = DateTime.Now.AddSeconds(_duration);
            while (DateTime.Now < endTime)
            {
                Console.WriteLine("\nBreathe in...");
                ShowCountdown(4);
                Console.WriteLine("Breathe out...");
                ShowCountdown(6);
            }
        }
    }
}
