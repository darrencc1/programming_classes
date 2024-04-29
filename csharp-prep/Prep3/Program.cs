using System;

class Program
{
    static void Main(string[] args)
    {
      Console.Write("What is the magic number? ");
      int magicNumber = int.Parse(Console.ReadLine());

      Console.Write("What is the magic number? ");
      int guess = int.Parse(Console.ReadLine());

      if (guess > magicNumber)
      {
        Console.WriteLine("Please guess a lower number");
      }
      else if (guess < magicNumber)
      {
        Console.WriteLine("Please Guess a higher number");
      } 
      else if (guess == magicNumber)
      {
        Console.WriteLine("Congratulations you guessed it!");
      }       
    }
}