public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        
        Console.WriteLine("Please enter the duration for this activity in seconds:");
        int _seconds = int.Parse(Console.ReadLine());
        SetDuration(_seconds);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_seconds);

        while (DateTime.Now < endTime)
        {
            Random random = new Random();
            int min = 2;  // Límite inferior
            int max = 6;  // Límite superior
            int randomNumber = random.Next(min, max + 1);

            Console.Write("Breathe in... ");
            ShowCountDown(randomNumber);
            Console.WriteLine("");
            Console.Write("Breathe out... ");
            ShowCountDown(randomNumber);
            Console.WriteLine("");
            Console.WriteLine("");
        }

        DisplayEndingMessage();
    }
}
