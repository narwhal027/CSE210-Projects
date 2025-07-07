// File: Program.cs
using System;

namespace EternalQuest
{
    public class Program
    {
        private static readonly Goals quest = new Goals();

        public static void Main()
        {
            quest.Load();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n1. View Goals  2. Record Event  3. Add Goal  4. View Profile  5. Save  6. Exit");
                Console.Write("Select: ");
                switch (Console.ReadLine())
                {
                    case "1": ViewGoals(); break;
                    case "2": RecordEvent(); break;
                    case "3": AddGoal(); break;
                    case "4": ViewProfile(); break;
                    case "5": quest.Save(); Console.WriteLine("Progress saved."); break;
                    case "6": quest.Save(); exit = true; break;
                    default: Console.WriteLine("Invalid selection."); break;
                }
            }
        }

        private static void ViewGoals()
        {
            Console.WriteLine("\n--- Goals ---");
            for (int i = 0; i < quest.AllGoals.Count; i++)
                Console.WriteLine($"{i + 1}. {quest.AllGoals[i]}");
        }

        private static void RecordEvent()
        {
            ViewGoals();
            Console.Write("Enter goal number: ");
            if (int.TryParse(Console.ReadLine(), out int idx)
                && idx > 0 && idx <= quest.AllGoals.Count)
            {
                int pts = quest.AllGoals[idx - 1].RecordEvent(quest);
                if (pts == 0)
                    Console.WriteLine("No points awarded (maybe already complete).");
            }
            else Console.WriteLine("Invalid goal number.");
        }

        private static void AddGoal()
        {
            Console.Write("Type (simple/eternal/checklist): ");
            string type = Console.ReadLine().ToLower();
            Console.Write("Name: "); string name = Console.ReadLine();
            Console.Write("Description: "); string desc = Console.ReadLine();
            Console.Write("Points per event: "); int pts = int.Parse(Console.ReadLine());
            BaseGoal goal = type switch
            {
                "simple" => new SimpleGoal(name, desc, pts),
                "eternal" => new EternalGoal(name, desc, pts),
                "checklist" => AddChecklistGoal(name, desc, pts),
                _ => null
            };
            if (goal != null)
                quest.AllGoals.Add(goal);
            else
                Console.WriteLine("Unknown goal type.");
        }

        private static ChecklistGoal AddChecklistGoal(string name, string desc, int pts)
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus points at completion: ");
            int bonus = int.Parse(Console.ReadLine());
            return new ChecklistGoal(name, desc, pts, target, 0, bonus);
        }

        private static void ViewProfile()
        {
            Console.WriteLine($"\nScore: {quest.Score} | Level: {quest.Level} | Title: {quest.Title}");
        }
    }
}