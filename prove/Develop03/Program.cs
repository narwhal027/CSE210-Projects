using System;
using System.Collections.Generic;
// For the creativity requirement I did 2 things. First, I made it so that the program can only hide words that weren't already hidden,
// and second I made it so you can choose from several scriptures at the beginning rather than only have one option.
class Program
{
    static void Main(string[] args)
    {
        // 1. Build a small “library” of scriptures (Reference + text)
        var scriptureLibrary = new List<(Reference reference, string text)>()
        {
            // Example 1: John 3:16
            (
                new Reference("John", 3, 16),
                "For God so loved the world, that he gave his only begotten Son, " +
                "that whosoever believeth in him should not perish, but have everlasting life."
            ),
            // Example 2: Proverbs 3:5-6
            (
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart; and lean not unto thine own understanding. " +
                "In all thy ways acknowledge him, and he shall direct thy paths."
            ),
            // Example 3: Philippians 4:13
            (
                new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me."
            )
        };

        // 2. Display the numbered list and prompt the user to choose
        Console.WriteLine("Select a scripture to memorize:");
        for (int i = 0; i < scriptureLibrary.Count; i++)
        {
            var (reference, _) = scriptureLibrary[i];
            Console.WriteLine($"{i + 1}) {reference}");
        }

        int choice = GetUserChoice(scriptureLibrary.Count);

        // 3. Instantiate Scripture for the chosen entry
        var chosenPair = scriptureLibrary[choice - 1];
        var scripture = new Scripture(chosenPair.reference, chosenPair.text);

        // 4. Main loop: display, wait for ENTER or “quit,” then hide words
        while (true)
        {
            scripture.Display();
            Console.Write("Press Enter to continue or type 'quit' to exit: ");
            string input = Console.ReadLine();

            if (input.Trim().ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);

            if (scripture.AllWordsHidden())
            {
                scripture.Display();
                Console.WriteLine("All words are hidden. Great job!");
                break;
            }
        }
    }

    // Method to prompt user choice and validate input
    // Returns an integer between 1 and maxOption (inclusive)
    private static int GetUserChoice(int maxOption)
    {
        while (true)
        {
            Console.Write($"Enter a number between 1 and {maxOption}: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int selected) &&
                selected >= 1 && selected <= maxOption)
            {
                return selected;
            }
            Console.WriteLine("Invalid selection. Please try again.");
        }
    }
}
