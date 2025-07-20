using System;

namespace EventPlanning
{
    public abstract class Event
    {
        public string Title { get; }
        public string Description { get; }
        public DateTime Date { get; }
        public TimeSpan Time { get; }
        public Address Address { get; }

        protected Event(string title, string description, DateTime date, TimeSpan time, Address address)
        {
            Title = title;
            Description = description;
            Date = date;
            Time = time;
            Address = address;
        }

        public virtual string GetStandardDetails()
        {
            return $"Title: {Title}\n" +
                   $"Description: {Description}\n" +
                   $"Date: {Date:MMMM dd, yyyy}\n" +
                   $"Time: {Time:hh\\:mm}\n" +
                   $"Address:\n{Address.GetFormattedAddress()}";
        }

        public abstract string GetFullDetails();

        public virtual string GetShortDescription()
        {
            return $"{GetType().Name}: {Title} on {Date:MMMM dd, yyyy}";
        }
    }
}
