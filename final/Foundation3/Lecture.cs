using System;

namespace EventPlanning
{
    public class Lecture : Event
    {
        public string Speaker { get; }
        public int Capacity { get; }

        public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
            : base(title, description, date, time, address)
        {
            Speaker = speaker;
            Capacity = capacity;
        }

        public override string GetFullDetails()
        {
            return GetStandardDetails() + "\n" +
                   $"Event Type: Lecture\n" +
                   $"Speaker: {Speaker}\n" +
                   $"Capacity: {Capacity}";
        }
    }
}
