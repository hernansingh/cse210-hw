public class GoalManager
{
    // Atributos
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public void SetScore(int score)
    {
        _score = score;
    }
    public int GetScore()
    {
        return _score;
    }

    // Métodos
    public void Start()
    {
        while (true)
        {
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. See score");
            Console.WriteLine("2. List goal names");
            Console.WriteLine("3. List goal details");
            Console.WriteLine("4. Create a new goal");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Save goals to file");
            Console.WriteLine("7. Load goals to file (not working)");
            Console.WriteLine("8. Quit");

            var userResponse = Console.ReadLine();

            if (userResponse == "1")
            {
                DisplayPlayerInfo();
            }
            else if (userResponse == "2")
            {
                ListGoalNames();
            }
            else if (userResponse == "3")
            {
                ListGoalDetails();
            }
            else if (userResponse == "4")
            {
                CreateGoal();
            }
            else if (userResponse == "5")
            {
                RecordEvent();
            }
            else if (userResponse == "6")
            {
                SaveGoals();
            }
            else if (userResponse == "7")
            {
                break;
            }
            else if (userResponse == "8")
            {
                break;
            }
            else
            {
                Console.WriteLine("Write a right answer");
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        int actualScore = GetScore();
        Console.WriteLine($"Your actual score is {actualScore}.");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("List goal names:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goal}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("List goal details:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("What style of goal do you want to upload?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        int goalType = int.Parse(Console.ReadLine());

        Console.Write("Enter the goal short name: ");
        string shortName = Console.ReadLine();

        Console.Write("Enter the goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter the score points: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        switch (goalType)
        {
            case 1: // Meta Simple
                newGoal = new SimpleGoal(shortName, description, points, false);
                break;

            case 2: // Meta Eterna
                newGoal = new EternalGoal(shortName, description, points);
                break;

            case 3: // Meta Checklist
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                int amountCompleted = 0;

                newGoal = new ChecklistGoal(shortName, description, points, amountCompleted, target, bonus);
                break;

            default:
                Console.WriteLine("Option it is not valid.");
                return;
        }

        _goals.Add(newGoal);
        Console.WriteLine($"\n¡'{shortName}' goal it was created succesfully!\n");

    }

    public void RecordEvent()
    {
        Console.WriteLine($"Which goal did you accomplish? ");

        int answer = int.Parse(Console.ReadLine()) - 1;
        

        if (answer >= 0 && answer < _goals.Count)
        {
            Goal selectedGoal = _goals[answer];
            selectedGoal.RecordEvent();
            int pointsEarned = selectedGoal.GetPoints();
            _score += pointsEarned;
            Console.WriteLine($"Congratulations! You have earned {pointsEarned} ");
            Console.WriteLine($"Now you have {_score} points.");

        }
        else
        {
            Console.WriteLine("Invalid goal number. Please try again.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Enter the file name to save goals: ");
        string fileName = Console.ReadLine();

        // Asegurarnos de usar un bloque using para liberar recursos
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Goal goal in _goals)
            {
                // Obtener la representación en cadena de cada meta
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine($"Goals saved successfully to {fileName}.");
    }

    public void LoadGoals()
    {
    }

}