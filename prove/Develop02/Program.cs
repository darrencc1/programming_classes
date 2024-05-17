using System;
 
class Program
{
    static void Main(string[] args)
    {
        
        Journal journal = new Journal();
         List<string> menu = ["Write", "Display", "Load", "Save", "Quit"];
        
         for (int i = 0; i < menu > Count; i++)
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
              break;
            case 4:
              Console.WriteLine("Save");
              break;
            case 5:
              Console.WriteLine("Quit");
              break;
          }
    }
}