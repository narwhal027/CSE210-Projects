using System;
using System.Security.Cryptography.X509Certificates;
// This is a comment.
// Another comment.

// class Circle
// {
//     private double _radius;

//     public void SetRadius(double radius)
//     {
//         if (radius < 0)
//         {
//             Console.WriteLine("Error");
//             return;
//         }
//         _radius = radius;
//     }

//     public double GetRadius()
//     {
//         return _radius;
//     }

//     public double GetArea()
//     {
//         return Math.PI * _radius * _radius;
//     }
// }
class Program
{
    private static void Main(string[] args)
    {
        int sleepTime = 250;
        Console.WriteLine("Yo Bob");
        DateTime currentTime = DateTime.Now;
        int time = 9;
        DateTime endTime = currentTime.AddSeconds(time);

        string animationString2 = "-+\\|/";
        int index = 0;


        int count = time - 5;
        while (DateTime.Now < endTime)
        {
            Console.Write(animationString2[index++ % animationString2.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");

        }
        endTime = currentTime.AddSeconds(10);
        string animationString = "(^_^)(-_-)";
        while (DateTime.Now < endTime)
        {
            Console.Write(animationString[0..5]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b");
            Console.Write(animationString[5..]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b");

            // Console.Write("|");
            // Thread.Sleep(sleepTime);
            // Console.Write("\b");
            // Console.Write("/");
            // Thread.Sleep(sleepTime);
            // Console.Write("\b");
            // Console.Write("-");
            // Thread.Sleep(sleepTime);
            // Console.Write("\b");
            // Console.Write(@"\");
            // Thread.Sleep(sleepTime);
            // Console.Write("\b");
        }
    }
    // static void Main(string[] args)
    // {
    //     Circle myCircle = new Circle(10);
    //     Circle myCircle2 = new Circle();
    //     // myCircle.SetRadius(10);
    //     Console.WriteLine($"{myCircle.GetRadius()}");

    //     myCircle2.SetRadius(20);
    //     Console.WriteLine($"{myCircle2.GetRadius()}");

    //     Console.WriteLine($"{myCircle.GetArea()}");
    //     Console.WriteLine($"{myCircle2.GetArea()}");


    //     Cylinder myCylinder = new Cylinder(100, 5);
    //     // myCylinder.SetCircle(myCircle);
    //     // myCylinder.SetHeight(10);
    //     Console.WriteLine($"{myCylinder.GetVolume()}");
    // Console.WriteLine("Hello Sandbox World!");
    // int x = 10;
    // if (x == 10)
    // {
    //     Console.WriteLine("X is 10");
    // }
    // for (int i = 0; i < x; i++)
    // {
    //     Console.WriteLine($"Logan is cool: {i * i}.");
    // }
    // }
}
