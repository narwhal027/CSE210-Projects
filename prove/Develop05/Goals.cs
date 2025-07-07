using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    public class Goals
    {
        private const string SaveFile = "quest_save.txt";
        public int Score { get; private set; } = 0;
        public int Level { get; private set; } = 1;
        public List<BaseGoal> AllGoals { get; private set; } = new List<BaseGoal>();

        public string Title
        {
            get
            {
                return Level switch
                {
                    <= 2 => "Novice",
                    <= 4 => "Apprentice",
                    <= 6 => "Journeyman",
                    <= 8 => "Expert",
                    _ => "Master",
                };
            }
        }

        public void AddScore(int pts) => Score += pts;

        public void CheckLevelUp()
        {
            int newLevel = (Score / 1000) + 1;
            if (newLevel > Level)
            {
                Level = newLevel;
                Console.WriteLine($"🎉 Level {Level} reached! ({Title}) 🎉");
            }
        }

        public void ShowCelebration() =>
            Console.WriteLine("★ ☆ ✩ Great Job! ✩ ☆ ★");

        public void Save()
        {
            using var writer = new StreamWriter(SaveFile);
            writer.WriteLine(Score);
            foreach (var g in AllGoals)
                writer.WriteLine(g.Serialize());
        }

        public void Load()
        {
            if (!File.Exists(SaveFile)) return;
            var lines = File.ReadAllLines(SaveFile);
            if (lines.Length < 1) return;

            if (int.TryParse(lines[0], out int savedScore))
                Score = savedScore;

            AllGoals.Clear();
            for (int i = 1; i < lines.Length; i++)
            {
                try
                {
                    var goal = BaseGoal.Deserialize(lines[i]);
                    AllGoals.Add(goal);
                }
                catch
                {
                    continue;
                }
            }
        }
    }
}