using System;

public class PromptGenerator
{
    //Status
    public string _prompts;

    // Behavior
    public string GetRandomPrompt()
    {
        Random _randomGenerator = new Random();
        int random = _randomGenerator.Next(1, 6);

        if (random == 1)
        {
            _prompts = "Who was the most interesting person I interacted with today?";
        }
        else if (random == 2)
        {
            _prompts = "What was the best part of my day?";
        }
        else if (random == 3)
        {
            _prompts = "How did I see the hand of the Lord in my life today?";
        }
        else if (random == 4)
        {
            _prompts = "What was the strongest emotion I felt today?";
        }
        else
        {
            _prompts = "If I had one thing I could do over today, what would it be?";
        }

        return _prompts;
    }
}