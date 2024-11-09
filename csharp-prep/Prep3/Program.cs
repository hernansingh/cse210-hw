using System;

class Program
{
    static void Main(string[] args)
    {

    Random randomGenerator = new Random();
    int random = randomGenerator.Next(1, 100);

    while (true)
    {

        Console.WriteLine("Guees your random number ");
        int guess = int.Parse(Console.ReadLine());

        if (random < guess)
        {
            Console.WriteLine("Lower");
        }

        else if (random > guess)
        {
            Console.WriteLine("Higher");
        }

        else
        {
            Console.WriteLine("You guessed it!");
            break;
        }
    }

    }
}