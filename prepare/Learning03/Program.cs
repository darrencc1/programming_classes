using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine($"Fraction 1: {fraction1}");

        Fraction fraction2 = new Fraction(6);
        Console.WriteLine($"Fraction 2 : {fraction2}");

        Fraction fraction3 = new Fraction(6, 15);
        Console.WriteLine($"Fraction 3: {fraction3}");

        // Create an instance of Fraction
        Fraction fraction = new Fraction();
        Console.WriteLine($"Initial Fraction: {fraction}");

        // Set new values using setters
        fraction.SetNumerator(8);
        fraction.SetDenominator(18);

        // Display the new values using getters
        Console.WriteLine($"New Fraction: {fraction.GetNumerator()}/{fraction.GetDenominator()}");

          Fraction fraction4 = new Fraction();
        Console.WriteLine($"Fraction 1: {fraction4} (Fraction String: {fraction4.GetFractionString()}, Decimal Value: {fraction4.GetDecimalValue()})");

        // Using the second constructor
        Fraction fraction5 = new Fraction(3);
        Console.WriteLine($"Fraction 2: {fraction5} (Fraction String: {fraction5.GetFractionString()}, Decimal Value: {fraction5.GetDecimalValue()})");

        // Using the third constructor
        Fraction fraction6 = new Fraction(2, 5);
        Console.WriteLine($"Fraction 3: {fraction6} (Fraction String: {fraction6.GetFractionString()}, Decimal Value: {fraction6.GetDecimalValue()})");
    }
}