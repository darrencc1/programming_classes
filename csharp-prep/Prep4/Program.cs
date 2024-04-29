using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = 1;
        int sum = 0;
        Console.Write("Enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            
            number = int.Parse(Console.ReadLine());
            sum += number;
            if (number == 0)
            {
                break;
            }
            numbers.Add(number);
        }
        Console.WriteLine("Entered numbers:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine($"Sum: {sum}");
    
    }
}