using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade_text = Console.ReadLine();
        float grade = float.Parse(grade_text);
        
        if (grade >= 90)
        {
            Console.WriteLine("Your grade is an A!");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Your grade is an B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Your grade is a C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Your grade is a D");
        }
        else if (grade < 60)
        {
            Console.WriteLine("You are failing this class!");
        }
    }
}