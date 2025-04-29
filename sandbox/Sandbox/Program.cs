using System;
using System.Security.Cryptography.X509Certificates;
// This is a comment.
// Another comment.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        int x = 10;
        if (x == 10)
        {
            Console.WriteLine("X is 10");
        }
        for (int i = 0; i < x; i++)
        {
            Console.WriteLine($"Logan is cool: {i * i}.");
        }
    }
}