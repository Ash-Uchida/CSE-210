using System;

class Program
{
    static void Main(string[] args)
    {
        
        DisplayWelcomeMessage();
        string name = PromptUserName();
        int num = PromptUserNumber();
        int year = PromtUserBirthYear();
        int squared = SquareNumber(num);
        int age = DisplayResult(year);

        DisplayResult(name,squared,age);
    }

        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string username = Console.ReadLine();
            return username;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string user = Console.ReadLine();
            int usernum = int.Parse(user);
            return usernum;
        }

        static int PromtUserBirthYear()
        {
            Console.Write("Please enter the year you were born: ");
            string user = Console.ReadLine();
            int year = int.Parse(user);
            return year;
        }

        static int SquareNumber(int num)
        {
            int squared = num * num;
            return squared;     
        }

        static int DisplayResult(int year)
        {
            int total_age = 2026 - year;
            return total_age;
        }
        
        static void DisplayResult(string name, int squared, int age)
        {
            Console.WriteLine($"{name}, the square of your number is {squared}");
            Console.WriteLine($"{name}, you will turn {age} this year");
        }

    
}