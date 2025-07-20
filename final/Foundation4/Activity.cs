using System;

namespace FitnessTracker
{
    public abstract class Activity
    {
        public DateTime Date { get; }
        public int DurationMinutes { get; }

        protected Activity(DateTime date, int durationMinutes)
        {
            Date = date;
            DurationMinutes = durationMinutes;
        }

        public virtual double GetDistance()
        {
            // default implementation (override where needed)
            return 0.0;
        }

        public virtual double GetSpeed()
        {
            // speed = distance (miles) / hours
            double hours = DurationMinutes / 60.0;
            return hours > 0 ? GetDistance() / hours : 0.0;
        }

        public virtual double GetPace()
        {
            // pace = minutes per mile
            double distance = GetDistance();
            return distance > 0 ? DurationMinutes / distance : 0.0;
        }

        public virtual string GetSummary()
        {
            return $"{Date:dd MMM yyyy} {GetType().Name} ({DurationMinutes} min) - " +
                   $"Distance: {GetDistance():0.00} miles, " +
                   $"Speed: {GetSpeed():0.00} mph, " +
                   $"Pace: {GetPace():0.00} min per mile";
        }
    }
}
