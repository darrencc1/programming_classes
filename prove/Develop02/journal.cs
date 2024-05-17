using System;


public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void NewEntry()
    {
        string prompt = "What is one thing you are grateful for?";
        Console.WriteLine($"{prompt}");
        Console.WriteLine("Enter your journal entry:");
        string response = Console.ReadLine();
        Entry entry = new Entry(response);
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        Console.WriteLine("Journal Entries:");
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.Content);
        }
    }
}