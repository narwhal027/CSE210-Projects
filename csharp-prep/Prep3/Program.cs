using System;

class Program
{
    static void Main(string[] args)
    {
        int numGuess = 0;
        Random rand = new Random();
        int randNum = rand.Next(1, 100);
        while (numGuess != randNum)
        {
            Console.WriteLine("Guess the magic number: ");
            numGuess = int.Parse(Console.ReadLine());
            if (numGuess == randNum)
            {
                Console.WriteLine("You guessed the number, congratulations!");
            }
            else if (numGuess > randNum)
            {
                Console.WriteLine("Too high.");
            }
            else
            {
                Console.WriteLine("Too low.");
            }
        }
    }
}