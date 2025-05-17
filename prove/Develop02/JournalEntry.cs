public class JournalEntry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Mood { get; set; }

    public JournalEntry(string date, string prompt, string response, string mood)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
        Mood = mood;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine($"Mood: {Mood}");
        Console.WriteLine();
    }

    public string ToFileFormat()
    {
        return $"{Date}|{Prompt}|{Response}|{Mood}";
    }

    public static JournalEntry FromFileFormat(string line)
    {
        var parts = line.Split('|');
        return new JournalEntry(parts[0], parts[1], parts[2], parts[3]);
    }
}
