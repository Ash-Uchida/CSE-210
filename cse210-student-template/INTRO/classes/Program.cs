// this is the default main

using System;

class Program
{
    static void Main(string[] args)
    {
        // first we inilaize it
        Journal journal1 = new Journal();


        // then we put the sttriutes for this object
        // always underscore then camel case for attributes
        journal1._prompts = ['Hi', 'Hello', 'Bye'];
        Random randomGenerator = new();
        int number = randomGenerator.Next(0, 2);   
        // this is calling the index , can print it or store to a varible
        journal1._prompts[number];

        Console.WriteLine("Type in your entry");
        string entry = Console.ReadLine();
        journal1._entrys.add(entry);

        // for the date
`       // #include <iostream>
        // #include <ctime>

        // int main() {
        //     time_t now = time(0);
        //     std::cout << "Current date: " << ctime(&now);
        //     return 0;
        // }   


    }
    
}

// Load and save would be functions but make write and display methods