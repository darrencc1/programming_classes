using System;


class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        List<string> menu = new List<string> { "Write", "Display", "Load", "Save", "Quit" };
        
        bool running = true;
        while (running)
        {
            Console.WriteLine("Menu:");
            for (int i = 0; i < menu.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {menu[i]}"); 
            }

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    journal.NewEntry();
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                case 3:
                    Console.WriteLine("Load");
                    // Implement load functionality here
                    break;
                case 4:
                    Console.WriteLine("Save");
                    // Implement save functionality here
                    break;
                case 5:
                    Console.WriteLine("Quit");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}