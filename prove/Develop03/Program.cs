using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string scriptureText = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";
        Scripture scripture = new Scripture(reference, scriptureText);
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("If you want to finish the cicle write \"quit\"");
        while (true)
        {

            string answer = Console.ReadLine().ToLower();

            if (answer == "quit")
            {
                break;
            }
            else
            {
                scripture.HideRandomWords(3);
                Console.WriteLine(scripture.GetDisplayText());
                if (scripture.IsCompletelyHidden())
                {
                    break;
                }
            }
        }
    }
}