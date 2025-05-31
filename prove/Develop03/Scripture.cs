using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    // Private fields must start with underscore and use _camelCase
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        // Split on spaces and turn each piece into a Word object
        _words = text
            .Split(' ')
            .Select(word => new Word(word))
            .ToList();
    }

    public void HideRandomWords(int count)
    {
        Random rand = new Random();

        // Filter out only the words that are still visible
        var visibleWords = _words.Where(w => !w.IsHidden).ToList();

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool AllWordsHidden()
    {
        // Return true only if every Word in '_words' is hidden
        return _words.All(w => w.IsHidden);
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(_reference.ToString());
        Console.WriteLine();

        // Print each word (hidden or not)
        foreach (var word in _words)
        {
            Console.Write(word + " ");
        }

        Console.WriteLine("\n");
    }
}
