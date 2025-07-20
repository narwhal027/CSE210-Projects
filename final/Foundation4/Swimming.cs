using System;

namespace FitnessTracker
{
    public class Swimming : Activity
    {
        public int Laps { get; }
        private const double MetersPerLap = 50.0;
        private const double MetersToMiles = 0.000621371;

        public Swimming(DateTime date, int durationMinutes, int laps)
            : base(date, durationMinutes)
        {
            Laps = laps;
        }

        public override double GetDistance()
        {
            // convert laps × 50m to miles
            return Laps * MetersPerLap * MetersToMiles;
        }

        public override double GetSpeed()
        {
            double hours = DurationMinutes / 60.0;
            double distance = GetDistance();
            return hours > 0 ? distance / hours : 0.0;
        }

        public override double GetPace()
        {
            double distance = GetDistance();
            return distance > 0 ? DurationMinutes / distance : 0.0;
        }
    }
}
