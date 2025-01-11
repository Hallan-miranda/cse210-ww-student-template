using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int randonNumber = randomGenerator.Next(1,100);
        int guess = 0;

        do{

        Console.Write("What is the magic number?");
        string number = Console.ReadLine();
        guess = int.Parse(number);

        Console.WriteLine($"Your Guess is: {guess}");

        if(randonNumber > guess){
            Console.WriteLine("Higher");
        }
        else if(randonNumber < guess){
            Console.WriteLine("Lower");
        }
        else{
            Console.WriteLine("You gussed it!");
        }

        }while(randonNumber != guess);
    }
}