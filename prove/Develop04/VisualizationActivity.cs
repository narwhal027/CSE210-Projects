using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    public class VisualizationActivity : MindfulnessActivity
    {
        private readonly List<string> _prompts = new()
        {
            "Visualize yourself overcoming a major challenge.",
            "Imagine yourself achieving one of your most important goals.",
            "Picture a moment when you are doing something you love and doing it well.",
            "Envision yourself helping someone in a powerful way."
        };

        private readonly List<string> _allGuidance = new()
        {
            "What does your face look like in this moment?",
            "Who is around you?",
            "What sounds or smells are in the air?",
            "How does your body feel?",
            "What emotions do you experience?",
            "What is the outcome of your success?"
        };

        private Queue<string> _guidanceQueue = new();

        public VisualizationActivity()
            : base("Visualization Activity",
                  "This activity will help you build confidence by visualizing a future success. " +
                  "Envision yourself achieving something meaningful. Picture the details, the environment, and how you’ll feel when it happens.")
        {
            ShuffleGuidanceIntoQueue();
        }

        private void ShuffleGuidanceIntoQueue()
        {
            var shuffled = new List<string>(_allGuidance);
            var rand = new Random();
            for (int i = shuffled.Count - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                (shuffled[i], shuffled[j]) = (shuffled[j], shuffled[i]);
            }
            _guidanceQueue = new Queue<string>(shuffled);
        }

        protected override void PerformActivity()
        {
            var rand = new Random();
            Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Count)]);
            ShowPauseAnimation(5);

            var endTime = DateTime.Now.AddSeconds(_duration);
            while (DateTime.Now < endTime)
            {
                if (_guidanceQueue.Count == 0)
                {
                    ShuffleGuidanceIntoQueue();
                }

                Console.WriteLine("\n" + _guidanceQueue.Dequeue());
                ShowPauseAnimation(7);
            }
        }
    }
}
