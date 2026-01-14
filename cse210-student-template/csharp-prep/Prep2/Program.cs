using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter = "";

        if (grade < 60)
        {
            letter = "F";
        }
        else if (grade < 70)
        {
            letter = "D";
        }
        else if (grade < 80)
        {
            letter = "C";
        }
        else if (grade < 90)
        {
            letter = "B";
        }
        else if (grade <= 100)
        {
            letter = "A";
        }
        else
        {
            Console.WriteLine("Please enter a vaild number");
        }

        Console.WriteLine($"Your grade is {letter}");

        if (grade < 70 )
        {
            Console.WriteLine("Looks like you didn't pass, better luck next time");
        }
        else
        {
            Console.WriteLine("Congrats you passed tha class!");
        }
    }
}