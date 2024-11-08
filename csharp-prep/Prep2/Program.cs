using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your calification? ");
        int number = int.Parse(Console.ReadLine());
        string letter ="";

        if (number >= 90 && number <= 100)
        {
            letter = "A";
        }
        else if (number >= 80 && number <= 100)
        {
            letter = "B";
        }
        else if (number >= 70 && number <= 100)
        {
            letter = "C";
        }
        else if (number >= 60 && number <= 100)
        {
            letter = "D";
        }
        else if (number >= 0 && number <= 100)
        {
            letter = "F";
        }



        if (number >= 70 && number <= 100)
        {
            Console.WriteLine($"Your grade is: {letter}");
            Console.WriteLine("Congrats! You passed the class!");
        }
        else if (number >= 0 && number <= 100)
        {
            Console.WriteLine($"Your grade is: {letter}");
            Console.WriteLine("You do not passed the class. Keep Going!");
        }
        else
        {
            Console.WriteLine("Write a right percent number");
        }
    }
}