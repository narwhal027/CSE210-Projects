using System;

namespace EventPlanning
{
    public class Reception : Event
    {
        public string RSVPEmail { get; }

        public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
            : base(title, description, date, time, address)
        {
            RSVPEmail = rsvpEmail;
        }

        public override string GetFullDetails()
        {
            return GetStandardDetails() + "\n" +
                   $"Event Type: Reception\n" +
                   $"RSVP to: {RSVPEmail}";
        }
    }
}
