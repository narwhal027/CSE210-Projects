// File: SimpleGoal.cs
using System;

namespace EternalQuest
{
    public class SimpleGoal : BaseGoal
    {
        public bool Completed { get; private set; }

        public SimpleGoal(string name, string description, int points, bool completed = false)
        {
            Name = name;
            Description = description;
            Points = points;
            Completed = completed;
            Type = "Simple";
        }

        public override int RecordEvent(Goals manager)
        {
            if (!Completed)
            {
                Completed = true;
                manager.AddScore(Points);
                manager.CheckLevelUp();
                manager.ShowCelebration();
                return Points;
            }
            return 0;
        }

        public override bool IsComplete() => Completed;

        public override string GetDisplayString() =>
            $"[{(Completed ? 'X' : ' ')}] {Name} ({Description}) – {Points} pts";
    }
}