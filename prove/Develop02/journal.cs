using System;

public class Journal
{
    private List<Entry> entries = newList<Entry>();
    public void NewEntry() {
    Console.WriteLine("Prompt");
    string response = Console.ReadLine();
    Entry entry = new Entry(response)
    entries.Add(entry)
    

    }
}

