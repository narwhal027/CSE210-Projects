class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World.");

        WordCounter wordCounter = new WordCounter("This is a text string that will test my counter class to see if things work well.");
        wordCounter.DisplayWords();
        int count = wordCounter.CountSingleWord("text");

        Console.WriteLine(count);
    }
}