// File: ChecklistGoal.cs
using System;

namespace EternalQuest
{
    public class ChecklistGoal : BaseGoal
    {
        public int TargetCount { get; private set; }
        public int CompletedCount { get; private set; }
        public int BonusPoints { get; private set; }

        public ChecklistGoal(
            string name,
            string description,
            int points,
            int targetCount,
            int completedCount = 0,
            int bonusPoints = 0)
        {
            Name = name;
            Description = description;
            Points = points;
            TargetCount = targetCount;
            CompletedCount = completedCount;
            BonusPoints = bonusPoints;
            Type = "Checklist";
        }

        public override int RecordEvent(Goals manager)
        {
            if (CompletedCount < TargetCount)
            {
                CompletedCount++;
                manager.AddScore(Points);
                int awarded = Points;
                if (CompletedCount == TargetCount)
                {
                    manager.AddScore(BonusPoints);
                    awarded += BonusPoints;
                }
                manager.CheckLevelUp();
                manager.ShowCelebration();
                return awarded;
            }
            return 0;
        }

        public override bool IsComplete() => CompletedCount >= TargetCount;

        public override string GetDisplayString()
        {
            char mark = IsComplete() ? 'X' : ' ';
            return $"[{mark}] {Name} ({CompletedCount}/{TargetCount}) – {Points} pts, bonus {BonusPoints}";
        }
    }
}