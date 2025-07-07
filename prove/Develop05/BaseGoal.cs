// File: BaseGoal.cs
using System;

namespace EternalQuest
{
    public abstract class BaseGoal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Points { get; set; }
        public string Type { get; protected set; }

        public abstract int RecordEvent(Goals manager);
        public abstract bool IsComplete();
        public abstract string GetDisplayString();
        public override string ToString() => GetDisplayString();

        public string Serialize()
        {
            switch (Type)
            {
                case "Simple":
                    var sg = (SimpleGoal)this;
                    return $"Simple|{Name}|{Description}|{Points}|{sg.Completed}";
                case "Eternal":
                    var eg = (EternalGoal)this;
                    return $"Eternal|{Name}|{Description}|{Points}|{eg.TimesCompleted}";
                case "Checklist":
                    var cg = (ChecklistGoal)this;
                    return $"Checklist|{Name}|{Description}|{Points}|{cg.CompletedCount}|{cg.TargetCount}|{cg.BonusPoints}";
                default:
                    throw new InvalidOperationException("Unknown goal type");
            }
        }

        public static BaseGoal Deserialize(string record)
        {
            var parts = record.Split('|');
            switch (parts[0])
            {
                case "Simple":
                    return new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                case "Eternal":
                    return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]));
                case "Checklist":
                    return new ChecklistGoal(
                        parts[1], parts[2],
                        int.Parse(parts[3]),
                        int.Parse(parts[5]),
                        int.Parse(parts[4]),
                        int.Parse(parts[6])
                    );
                default:
                    throw new InvalidOperationException("Unknown goal type");
            }
        }
    }
}