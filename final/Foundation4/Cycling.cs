using System;

namespace FitnessTracker
{
    public class Cycling : Activity
    {
        public double SpeedMph { get; }

        public Cycling(DateTime date, int durationMinutes, double speedMph)
            : base(date, durationMinutes)
        {
            SpeedMph = speedMph;
        }

        public override double GetDistance()
        {
            // distance = speed * hours
            double hours = DurationMinutes / 60.0;
            return SpeedMph * hours;
        }

        public override double GetPace()
        {
            // pace = minutes per mile = 60 / speed
            return SpeedMph > 0 ? 60.0 / SpeedMph : 0.0;
        }
    }
}
