using System;

class Program
{
    static void Main(string[] args)
    {
            int userChoice = 1;
            while (userChoice != 0)
        {
        Console.WriteLine("1. Write New Entry");
        Console.WriteLine("2. Load Entry");
        Console.WriteLine("3. Save Journal");
        Console.WriteLine("4. Display Journal");
        Console.WriteLine("Press 0 to end program");
        Console.Write("Please Pick a Number Option: ");
        userChoice = int.Parse(Console.ReadLine());  
        }
       
    
    }
}