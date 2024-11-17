using System;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    //Status
    public string _entryText;
    public string _promptText;
    public string _date;

    // Behavior
    public string DisplayDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
        return _date;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}\nAnswer: {_entryText}");
    }
}