using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Mindfulness Program ");

        int response = 0; 
        while(response != 4)
        {
            Console.Write(" \n Menu Options: \n 1. Breathing Activity \n 2. Reflecting Activity \n 3. Listing Activity \n 4. Quit \nSelect a choice from the menu: ");
            string userInput = Console.ReadLine();
            response = int.Parse(userInput); 

            if(response == 1)
            {
                //First we declare what in the constructor, then the methods from activity.cs and breathing.cs
                Breathing activity1 = new Breathing("Breathing","This activity will help you relax by walking you through breathing in and out slowly. Clear you mind and focus on your breathing.");
                activity1.Intro();
                activity1.GetDuration();

                activity1.BreathingActivity();

                activity1.Outro();
                Timer.Animation(5);
            }

            else if(response == 2)
            {
                // call the reflecting.cs
                Reflecting activity2 = new Reflecting("Relflecting","This activity will help you reflect on times in your life where you have shown strength and resilence. This will help you reconize the power you have and how you can use it in other aspects of you life.");
                activity2.Intro();
                activity2.GetDuration();

                activity2.ReflectingActivity();

                activity2.Outro();
                Timer.Animation(5);
            }

            else if(response == 3)
            {
                //call the listing.cs
                Listing activity3 = new Listing("Listing","This activity will help you reflect on the good things in your life by having you list as many things s you can in a certain area.");
                activity3.Intro();
                activity3.GetDuration();

                activity3.ListActivity();

                activity3.Outro();
                Timer.Animation(5);
            }
            else if(response == 4)
            {
                Console.WriteLine("GoodBye!");
            }
            else if(response == 100)
            {
                Timer.Secret(5);
            }
            else
            {
                Console.WriteLine("Secret option selected!");
                Timer.extraCredit(5);

                Console.WriteLine("If you want to see something fun type 100 when the menu reappears!");
            }
            
        };
    }
}