using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        /*Console.WriteLine(assignment1.GetSumary());*/

        MathAssignment assignment2 = new MathAssignment("Roberto Rodrigues", "Fractions", "Section 7.3", "Problems 8-19");
        /*Console.WriteLine(assignment2.GetSumary());
        Console.WriteLine(assignment2.GetHomeworkList());*/

        WritingAssigment assignment3 = new WritingAssigment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(assignment3.GetSumary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}