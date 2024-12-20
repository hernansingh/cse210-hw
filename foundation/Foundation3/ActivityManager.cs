public class ActivityManager
{
    // Sta
    private List<Activity> _activity = new List<Activity>();

    // Beh
    public void Start()
    {
        while (true)
        {
            Console.WriteLine("Exercise Tracker Menu:");
            Console.WriteLine("1. Add Running Activity");
            Console.WriteLine("2. Add Cycling Activity");
            Console.WriteLine("3. Add Swimming Activity");
            Console.WriteLine("4. Show All Activities");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            string userResponse = Console.ReadLine();

            if (userResponse == "1")
            {
                Console.WriteLine("You selected: Add Running Activity");
                RunningActivity();
            }
            else if (userResponse == "2")
            {
                Console.WriteLine("You selected: Add Cycling Activity");
                CyclingActivity();
            }
            else if (userResponse == "3")
            {
                Console.WriteLine("You selected: Add Swimming Activity");
                SwimmingActivity();
            }
            else if (userResponse == "4")
            {
                Console.WriteLine("You selected: Show All Activities");
                ShowAllActivities();
            }
            else if (userResponse == "5")
            {
                Console.WriteLine("Exiting program. Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }

            Console.WriteLine();
        }
    }

    public void RunningActivity()
    {
        Console.Write("Enter the date of the activity (e.g., 03/11/2022): ");
        string date = Console.ReadLine();

        Console.Write("Enter the duration in minutes: ");
        int duration = int.Parse(Console.ReadLine());

        Console.Write("Enter the distance in miles: ");
        double distance = double.Parse(Console.ReadLine());

        _activity.Add(new Running(date, duration, distance));
        Console.WriteLine("Running activity added successfully!");
    }

    public void CyclingActivity()
    {
        Console.Write("Enter the date of the activity (e.g., 03/11/2022): ");
        string date = Console.ReadLine();

        Console.Write("Enter the duration in minutes: ");
        int duration = int.Parse(Console.ReadLine());

        Console.Write("Enter the average speed in mph: ");
        double speed = double.Parse(Console.ReadLine());

        _activity.Add(new Cycling(date, duration, speed));
        Console.WriteLine("Cycling activity added successfully!");
    }

    public void SwimmingActivity()
    {
        Console.Write("Enter the date of the activity (e.g., 03/11/2022): ");
        string date = Console.ReadLine();

        Console.Write("Enter the duration in minutes: ");
        int duration = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of laps: ");
        int laps = int.Parse(Console.ReadLine());

        _activity.Add(new Swimming(date, duration, laps));
        Console.WriteLine("Swimming activity added successfully!");
    }

    public void ShowAllActivities()
    {
        if (_activity.Count == 0)
        {
            Console.WriteLine("No activities recorded yet.");
            return;
        }

        for (int i = 0; i < _activity.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_activity[i].GetSummary()}");
        }
    }
}
