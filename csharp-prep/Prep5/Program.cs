using System;

class Program
{
    static void Main(string[] args)
    {

        DislayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);


        static void DislayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        
        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            int favoriteNumber = int.Parse(Console.ReadLine());
            SquareNumber(favoriteNumber);

            return favoriteNumber;
        }

        static int SquareNumber(int number)
        {
            int result = number * number;

            return result;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }



    }
}