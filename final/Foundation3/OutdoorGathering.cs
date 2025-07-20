using System;

namespace EventPlanning
{
    public class OutdoorGathering : Event
    {
        public string WeatherForecast { get; }

        public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
            : base(title, description, date, time, address)
        {
            WeatherForecast = weatherForecast;
        }

        public override string GetFullDetails()
        {
            return GetStandardDetails() + "\n" +
                   $"Event Type: Outdoor Gathering\n" +
                   $"Weather: {WeatherForecast}";
        }
    }
}
