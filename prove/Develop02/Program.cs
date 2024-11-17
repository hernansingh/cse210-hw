using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Journal _journal = new Journal();
        PromptGenerator _promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                // AddEntry
                Entry _entry = new Entry();
                //Get Prompt
                string prompt = _promptGenerator.GetRandomPrompt();
                //Print Prompt
                Console.WriteLine(prompt);
                //Store Prompt in Instance
                _entry._promptText = prompt;
                //Get Date
                string _actualDate = _entry.DisplayDate();
                //Store Date in Instance
                _entry._date = _actualDate;
                //User Response
                string _actualEntryUser = Console.ReadLine();
                //Store User Response
                _entry._entryText = _actualEntryUser;
                //Store entry on List Jorunal
                _journal._entries.Add(_entry);

            }
            else if (choice == 2)
            {
                // DisplayAll
                foreach (Entry j in _journal._entries)
                {
                    j.Display();
                }
            }
            else if (choice == 3)
            {
                // LoadFromFile
                _journal.LoadFromFile();
            }
            else if (choice == 4)
            {
                // SaveToFile
                _journal.SaveToFile();
            }

            else
            {
                break;
            }
        }
    }
}