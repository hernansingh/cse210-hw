using System.Security.Cryptography.X509Certificates;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private static readonly Random _random = new Random();

    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions) : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void SetPrompts(List<string> prompts)
    {
        _prompts = prompts;
    }

    public void SetQuestions(List<string> questions)
    {
        _questions = questions;
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Enter the duration for this activity in seconds:");
        int _seconds = int.Parse(Console.ReadLine());
        SetDuration(_seconds);

        DisplayPrompt();

        DisplayQuestions();

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        int index = _random.Next(_questions.Count);
        string question = _questions[index];
        _questions.RemoveAt(index);
        return question;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(4);
        Console.WriteLine("Consider the following prompt...\n");
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as theyu related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
    }

    public void DisplayQuestions()
    {
        var spinnerDelay = _duration / 2; // Calcula una vez el valor fuera del bucle

        int iteration;
        
        if (_duration <= 10)
        {
            iteration = 1;
        }
        else
        {
            iteration = (int)Math.Round((double)_duration / 10);
        }

        for (int i = iteration; i > 0; i--)
        {
            string _question = GetRandomQuestion();
            Console.Write(_question);
            ShowSpinner(10);
            Console.WriteLine("");
        }
    }
}