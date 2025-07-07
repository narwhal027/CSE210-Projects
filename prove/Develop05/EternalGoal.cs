using System;

namespace EternalQuest
{
    public class EternalGoal : BaseGoal
    {
        public int TimesCompleted { get; private set; }

        public EternalGoal(string name, string description, int points, int timesCompleted = 0)
        {
            Name = name;
            Description = description;
            Points = points;
            TimesCompleted = timesCompleted;
            Type = "Eternal";
        }

        public override int RecordEvent(Goals manager)
        {
            TimesCompleted++;
            manager.AddScore(Points);
            manager.CheckLevelUp();
            manager.ShowCelebration();
            return Points;
        }

        public override bool IsComplete() => false;

        public override string GetDisplayString() =>
            $"📖 {Name} – {TimesCompleted} times – {Points} pts each";
    }
}