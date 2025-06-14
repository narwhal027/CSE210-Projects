using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    public class ReflectionActivity : MindfulnessActivity
    {
        private readonly List<string> _prompts = new()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private readonly List<string> _allQuestions = new()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        private Queue<string> _questionQueue = new();

        public ReflectionActivity()
            : base("Reflection Activity",
                  "This activity will help you reflect on times in your life when you have shown strength and resilience.\n" +
                  "This will help you recognize the power you have and how you can use it in other aspects of your life.")
        {
            ShuffleQuestionsIntoQueue();
        }

        private void ShuffleQuestionsIntoQueue()
        {
            var shuffled = new List<string>(_allQuestions);
            var rand = new Random();
            for (int i = shuffled.Count - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                (shuffled[i], shuffled[j]) = (shuffled[j], shuffled[i]);
            }
            _questionQueue = new Queue<string>(shuffled);
        }

        protected override void PerformActivity()
        {
            var rand = new Random();
            Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Count)]);
            ShowPauseAnimation(5);

            var endTime = DateTime.Now.AddSeconds(_duration);
            while (DateTime.Now < endTime)
            {
                if (_questionQueue.Count == 0)
                {
                    ShuffleQuestionsIntoQueue();
                }

                Console.WriteLine("\n" + _questionQueue.Dequeue());
                ShowPauseAnimation(6);
            }
        }
    }
}
