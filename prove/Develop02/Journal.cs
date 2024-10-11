using System;
using System.IO;

public class Journal
{
    List<Entry> _entries = new List<Entry>();
    public void AddEntry()
    {
        Entry newEntry = new Entry();
        
        newEntry._timestamp = newEntry.GetDateTime();
        newEntry._prompt = newEntry.GetPrompt();
        newEntry.DisplayPrompt();
        newEntry._body = newEntry.GetResponse();

        _entries.Add(newEntry);
    }
    public void DisplayEntries()
    {
        if (_entries.Count != 0)
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        else
            Console.WriteLine("There are no journal entries to display.");
    }
    public void LoadFile()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");
            Entry newEntry = new Entry();
        
            newEntry._timestamp = parts[0];
            newEntry._prompt = parts[1];
            newEntry._body = parts[2];

            _entries.Add(newEntry);
        }
    }
    public void SaveFile()
    {
        Console.Write("What do you want to name the file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._timestamp}|{entry._prompt}|{entry._body}");
            }
        }
    }
}

