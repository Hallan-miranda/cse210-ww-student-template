using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> Numbers = new List<int>();
        int thisNumber ;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do{

            Console.Write("Enter number: ");
            string num = Console.ReadLine();
            int number = int.Parse(num);

            Numbers.Add(number);
            thisNumber = number;


        }while(thisNumber != 0);

        int sumTotal = 0;
        int largest = 0;

        foreach (var number in Numbers)
        {
            sumTotal += number;

            if(largest < number)
            {
                largest = number;
            }
        }
        int smallest = largest;

        foreach (var number in Numbers)
        {

            if(smallest > number && number != 0 && number > 0)
            {
                smallest = number;
            }
        }

        double average = (double)sumTotal / (Numbers.Count -1) ;
        double roundAverage = Math.Round(average, 3);
        Console.WriteLine($" {Numbers.Count} ");
        Console.WriteLine($" {sumTotal} ");


        Numbers.Sort();

        Console.WriteLine($"The average is: {roundAverage} ");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        Console.WriteLine($"The sorted list is:");

        foreach (var number in Numbers)
        {
            Console.WriteLine($"{number}");
        }
    }
}