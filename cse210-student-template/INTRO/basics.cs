using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq.Expressions;
class Program
{
    static void Main()
    {
        // Storing and printing varibles
        int x = 5;
        int y = 6;
        Console.WriteLine(x);
        Console.Write(x);
        // we have int, string, float, bool, double: a float that takes up double the memory, can hold larger nums
        // ------------------------------------------------------------------------------------------------------------

        // User input
        Console.Write("What is your favorite color: ");
        string color = Console.ReadLine();

        // if else statments
        if (x < y)
        {
            Console.WriteLine("greater");
        }
        else if (x > y)
        {
            Console.WriteLine("lesser");
        }
        else
        {
            Console.WriteLine("neither");
        }

        // f string
        string school = "BYUI";
        Console.WriteLine($"I am studing at {school}");

        // comparison operators: ==, !=, >=, <=, &&, ||

        // Converting types
        string value = "42";
        int number = int.Parse(value);

        Console.WriteLine("What is your favorite number: ");
        string userInput = Console.ReadLine();
        int favNum = int.Parse(userInput);

        // while loops
        while (x < y)
        {
            y += 1;
        }

        //for loops
        // (inistalize : Logical expression : Modifier )
        // for ( )
        // {
            
        // }

        // lists
        newlist = List< int > = [1, 2, 3];
        newlist.Add(6);
        ConsoleTraceListener.WriteLine(newlist);

        // defining functions
        int my_func(int i)
        {
           New_num = i+1;
           return New_num; 
        }


    }
}

