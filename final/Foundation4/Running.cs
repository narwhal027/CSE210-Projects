using System;

namespace FitnessTracker
{
    public class Running : Activity
    {
        public double DistanceMiles { get; }

        public Running(DateTime date, int durationMinutes, double distanceMiles)
            : base(date, durationMinutes)
        {
            DistanceMiles = distanceMiles;
        }

        public override double GetDistance()
        {
            return DistanceMiles;
        }

        public override double GetSpeed()
        {
            double hours = DurationMinutes / 60.0;
            return hours > 0 ? DistanceMiles / hours : 0.0;
        }

        public override double GetPace()
        {
            return DistanceMiles > 0 ? DurationMinutes / DistanceMiles : 0.0;
        }
    }
}
