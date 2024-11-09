using System;
using System.Globalization;


class Program
{

    static void Main(string[] args)
    {
    
    int total = 0;
    int trys = 0;
    int largest = int.MinValue;
    List<string> listNumbers = new List<string>();

    while (true)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.WriteLine("Enter number: ");
        int numbers = int.Parse(Console.ReadLine());

        if (numbers != 0)
        {
            listNumbers.Add(numbers.ToString());
        }
        else
        {
            break;
        }
    }

    foreach (string number in listNumbers)
    {
        total += int.Parse(number);
        trys = trys + 1;

        int currentNumber = 0;
        if (int.TryParse(number, out currentNumber))
        {
            if (currentNumber > largest)
            {
                largest = currentNumber;
            }
        }
    }
    
    float avg = (float)total / trys;

    Console.WriteLine($"The sum is: {total}");
    Console.WriteLine($"The average is: {avg}");
    Console.WriteLine($"The largest number is: {largest}");
    }
}