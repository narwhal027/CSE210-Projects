class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.AddEntry();
                    break;
                case "2":
                    journal.DisplayAllEntries();
                    break;
                case "3":
                    Console.Write("Enter filename to save (add .txt to the end): ");
                    journal.SaveToFile(Console.ReadLine());
                    break;
                case "4":
                    Console.WriteLine($"Current directory: {Directory.GetCurrentDirectory()}");
                    Console.Write("Enter filename to load: ");
                    journal.LoadFromFile(Console.ReadLine());
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
