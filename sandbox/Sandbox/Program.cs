using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        int x;
        x = 5;
        Console.WriteLine(x);
        int y;
        y = 1;
        Console.Write("What is your favorite color? ");
        string color = Console.ReadLine();

        if (x > y)
        {
            Console.WriteLine("greater");
        }
        string school = "BYU-Idaho";
        Console.WriteLine($"I am studying at {school}.");
    }
}

