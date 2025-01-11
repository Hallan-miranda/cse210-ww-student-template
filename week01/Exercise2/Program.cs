using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("Whats is your grade porcent? ");
        string porcent = Console.ReadLine();
        int grade = int.Parse(porcent);

        string simbol = "";

        if((grade%10) >= 7){
            simbol = "+";
        }
        else if((grade%10) < 3){
            simbol = "-";
        }

        string letter = "";

        if (grade >= 90){
            letter = "A";
        }
        else if(grade >= 80){
            letter = "B";
        }
        else if(grade >= 70){
            letter = "C";
        }
        else if(grade >= 60){
            letter = "D";
        }
        else {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}{simbol}");

        if(grade > 70){
            Console.WriteLine("You Passed");
        }
        else{
            Console.WriteLine("You can try again, luke next time");
        }

    }
}