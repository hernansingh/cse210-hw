public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name}");
        Thread.Sleep(3000);
        Console.WriteLine($"{_description}");
        Thread.Sleep(5000);
        Console.WriteLine("Let's begin...");

    }

    public void DisplayEndingMessage()
    {
        Console.Write("Well Done...");
        ShowSpinner(4);
        Console.WriteLine("");
        Console.WriteLine($"You have complete another {_duration} seconds of {_name}");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string> { "|", "/", "-", "\\", "|", "/", "-", "\\" };

        Thread.Sleep(500);

        DateTime startTime = DateTime.Now;

        // Si el valor de seconds es negativo, ejecuta el spinner infinitamente
        DateTime endTime = seconds < 0 ? DateTime.MaxValue : startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];

            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            // Vuelve a empezar desde el primer elemento de la lista cuando i se sale de los límites
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }


    public void ShowCountDown(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            TimeSpan remainingTime = endTime - DateTime.Now;
            
            Console.Write($"{remainingTime.Seconds}"); 
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
