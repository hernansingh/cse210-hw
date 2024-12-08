public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration, List<string> prompts, int count) : base(name, description, duration)
    {
        _prompts = prompts;
        _count = count;
    }

    public void SetCount(int count)
    {
        _count = count;
    }

    public void SetPrompts(List<string> prompts)
    {
        _prompts = prompts;
    }
    // BEHAVIOR
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Enter the duration for this activity in seconds:");
        int _seconds = int.Parse(Console.ReadLine());
        SetDuration(_seconds);

        GetRandomPrompt();

        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(4);

        Console.WriteLine("List as many responses you can to the following prompt:");
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);

        Console.Write("You may begin in: ");
        ShowCountDown(5);

        // Start the activity and let the user input responses
        List<string> userResponses = GetListFromUser();
        _count = userResponses.Count;

        Console.WriteLine($"You listed {_count} items.");
    }

    public List<string> GetListFromUser()
    {
        List<string> userResponses = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.WriteLine("Start listing your responses:");

        // Collect user input within the duration
        while (DateTime.Now < endTime)
        {
            string response = Console.ReadLine();
            if (!string.IsNullOrEmpty(response))
            {
                userResponses.Add(response);
            }
        }

        return userResponses;
    }
}