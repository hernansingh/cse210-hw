using System;
using System.Security.Cryptography.X509Certificates;

public class Journal
{
    //Status
    public List<Entry> _entries = new List<Entry>();

    // Behavior
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entries in _entries)
        {
            entries.Display();
        }
    }
    public void SaveToFile()
    {
        Console.WriteLine("Saving to file...");

        Console.WriteLine("Enter the name of the file to save (example: entries.txt):");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date}|{e._promptText}|{e._entryText}");
            }
        }
    }
    public void LoadFromFile()
    {
        Console.WriteLine("Reading list from file...");
        
        Console.WriteLine("Enter the name of the file to load (example: entries.txt):");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            // Divide la línea en partes usando el delimitador '|'
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry newEntry = new Entry();
                newEntry._date = parts[0];
                newEntry._promptText = parts[1];
                newEntry._entryText = parts[2];
                _entries.Add(newEntry);
            }
        }

    }
}