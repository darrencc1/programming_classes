using System;


class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.UserEntry}");
            Console.WriteLine();
        }
    }

    public string SerializeEntries()
    {
        string serialized = "";
        foreach (var entry in entries)
        {
            serialized += $"{entry.Date}|{entry.Prompt}|{entry.UserEntry}\n";
        }
        return serialized.Trim();
    }

    public void DeserializeEntries(string data)
    {
        entries.Clear();
        string[] lines = data.Split('\n');
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            DateTime date = DateTime.Parse(parts[0]);
            string prompt = parts[1];
            string userEntry = parts[2];
            entries.Add(new Entry(userEntry, prompt, date));
        }
    }
}