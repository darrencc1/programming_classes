using System;

class Program
{
static void Main(string[] args)
        {
            
            Reference reference = new Reference("John", 3, new int[] { 16 });
            var text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
            Scripture scripture = new Scripture(reference, text);

            while (scripture.HasWordsLeft())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetMaskedText());
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
                scripture.MaskRandomWord();
            }

            Console.Clear();
            Console.WriteLine(scripture.GetMaskedText());
            Console.WriteLine("\nAll words are hidden. Press Enter to end the program.");
            Console.ReadLine();
        }
}