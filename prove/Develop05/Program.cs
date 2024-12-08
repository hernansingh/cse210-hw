using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> prompt = new List<string>
        {
            "--- Think of a time when you stood up for someone else. ---",
            "--- Think of a time when you did something really difficult. ---",
            "--- Think of a time when you helped someone in need. ---",
            "--- Think of a time when you did something truly selfless. ---"
        };

        List<string> questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        BreathingActivity breathingActivity1 = new BreathingActivity("Breating Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);

        ReflectingActivity reflectingActivity1 = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strenght and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0, prompt, questions);

        List<string> randomPrompt = new List<string>
        {
            "--- Who are people that you appreciate? ---",
            "--- What are personal strengths of yours? ---",
            "--- Who are people that you have helped this week? ---",
            "--- When have you felt the Holy Ghost this month? ---",
            "--- Who are some of your personal heroes? ---"
        };

        ListingActivity listingActivity1 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0, randomPrompt, 0);

        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");

            var userResponse = Console.ReadLine();

            if (userResponse == "1")
            {
                breathingActivity1.Run();
            }
            else if (userResponse == "2")
            {
                reflectingActivity1.Run();
            }
            else if (userResponse == "3")
            {
                listingActivity1.Run();
            }
            else if (userResponse == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Write a right answer");
            }
        }
    }
}