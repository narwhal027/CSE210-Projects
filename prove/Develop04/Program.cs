using System;

namespace MindfulnessApp
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Mindfulness App");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Visualization Activity");
                Console.WriteLine("5. Quit");
                Console.Write("Select an option: ");

                var choice = Console.ReadLine();
                MindfulnessActivity activity = choice switch
                {
                    "1" => new BreathingActivity(),
                    "2" => new ReflectionActivity(),
                    "3" => new ListingActivity(),
                    "4" => new VisualizationActivity(),
                    _ => null
                };
                if (activity == null) break;

                activity.Run();
                Console.WriteLine("\nPress any key to return to menu...");
                Console.ReadKey();
            }
        }
    }
}
