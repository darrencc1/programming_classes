using System;


class Program
{
    static Journal journal = new Journal(); 
    static Dictionary<string, string> savedJournals = new Dictionary<string, string>();

    static void Main(string[] args)
    {
        int userChoice = 1;
        while (userChoice != 0)
        {  
            Console.WriteLine("Journal Options");
            Console.WriteLine("1. Write New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("0. Exit Program.");
            Console.Write("Choose a number: ");
            userChoice = int.Parse(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    string userEntry = Entry.CreateEntry();
                    journal.AddEntry(new Entry(userEntry, Entry.GeneratePrompt(), DateTime.Now));
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                case 3:
                    Console.Write("Enter a name for this journal entry: ");
                    string saveName = Console.ReadLine();
                    string serializedData = journal.SerializeEntries();
                    savedJournals[saveName] = serializedData;
                    Console.WriteLine("Journal saved.");
                    break;
                case 4:
                    Console.Write("Enter the name of the journal entry to load: ");
                    string loadName = Console.ReadLine();
                    if (savedJournals.ContainsKey(loadName))
                    {
                        string dataToLoad = savedJournals[loadName];
                        journal.DeserializeEntries(dataToLoad);
                        Console.WriteLine("Journal loaded. Displaying entries:");
                        journal.DisplayEntries();
                    }
                    else
                    {
                        Console.WriteLine("No journal entry found with that name.");
                    }
                    break;
                case 0:
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}