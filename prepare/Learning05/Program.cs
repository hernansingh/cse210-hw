using System;

class Program
{
    static void Main(string[] args)
    {
        var mathAssignment = new MathAssignment("Hernan Singh", "Algebra", "Section 3.2", "Problems 1-10");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomewerkList());

        var writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}