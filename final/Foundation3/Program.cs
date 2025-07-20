using System;
using System.Collections.Generic;

namespace EventPlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            // Shared address
            var address = new Address("123 Celebration Ave", "Festivity City", "CA", "USA");

            // Create one of each event type
            var lecture = new Lecture(
                "The Future of AI",
                "Exploring trends in artificial intelligence.",
                new DateTime(2025, 9, 15),
                new TimeSpan(18, 30, 0),
                address,
                "Dr. Ada Lovelace",
                150
            );

            var reception = new Reception(
                "Networking Gala",
                "An evening of connections and refreshments.",
                new DateTime(2025, 10, 5),
                new TimeSpan(19, 0, 0),
                address,
                "rsvp@eventco.com"
            );

            var outdoor = new OutdoorGathering(
                "Summer Concert in the Park",
                "Live music under the stars.",
                new DateTime(2025, 8, 20),
                new TimeSpan(20, 0, 0),
                address,
                "Clear skies, 75°F"
            );

            // Collect all events
            var events = new List<Event> { lecture, reception, outdoor };

            // Display messages for each
            foreach (var ev in events)
            {
                Console.WriteLine("=== Standard Details ===");
                Console.WriteLine(ev.GetStandardDetails());
                Console.WriteLine();

                Console.WriteLine("=== Full Details ===");
                Console.WriteLine(ev.GetFullDetails());
                Console.WriteLine();

                Console.WriteLine("=== Short Description ===");
                Console.WriteLine(ev.GetShortDescription());
                Console.WriteLine(new string('-', 40));
            }
        }
    }
}
