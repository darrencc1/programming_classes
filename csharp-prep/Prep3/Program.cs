using System;

class Program
{
    static void Main(string[] args)
    {
      Random randomGenerator = new Random();
      int magicNumber = randomGenerator.Next(1, 11);
      
      int guessCount = 0;
      int guess = 0;
      while (guess != magicNumber) 
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            guessCount = guessCount + 1;
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
            Console.WriteLine($"It took you {guessCount} times to guess the number.");
        }  
       }      
    }
}