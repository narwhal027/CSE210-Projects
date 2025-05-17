public class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();
    private List<string> prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    private Random random = new Random();

    public void AddEntry()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        Console.Write("How are you feeling? (e.g., Happy, Sad, Excited, Stressed): ");
        string mood = Console.ReadLine();

        string date = DateTime.Now.ToShortDateString();

        JournalEntry entry = new JournalEntry(date, prompt, response, mood);
        entries.Add(entry);
    }
    public void DisplayAllEntries()
    {
        foreach (var entry in entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                outputFile.WriteLine(entry.ToFileFormat());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();
        var lines = File.ReadAllLines(filename);
        foreach (var line in lines)
        {
            entries.Add(JournalEntry.FromFileFormat(line));
        }
    }

    private string GetRandomPrompt()
    {
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}
