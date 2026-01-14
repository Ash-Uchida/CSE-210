using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string play = "yes";
        while( play == "yes")
        {
            Random random = new();
            int magic_num = random.Next(0, 101);
            Console.WriteLine(magic_num);
            int guess = -1;
            int guess_num =0;

            while (guess != magic_num)
            {
                Console.Write("Guess the number (1- 100): ");
                guess = int.Parse(Console.ReadLine());

                if (guess > magic_num)
                {
                    Console.WriteLine("lower");
                    guess_num +=1;
                }
                else if (guess < magic_num)
                {
                    Console.WriteLine("higher");
                    guess_num +=1;
                }
                else
                {
                    guess_num +=1;
                    Console.WriteLine($"That's correct! It took you {guess_num} guesses");
                    Console.WriteLine("Do you want to play again? (yes/no): ");
                    play = Console.ReadLine();
                }
            
            }

        }

    }
}