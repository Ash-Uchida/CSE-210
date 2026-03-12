using System;
using System.Data;
using System.IO; 
class Program
{
    static void Main(string[] args)
    {
        List<Goals> allGoals = new List<Goals>();

        int response = 0;
        while(response != 6)
        {
            // Goals goal = new Goals();
            // goal.displayPoints();

            Console.Write("\nMenu Options: \n   1. Create New Goal \n   2. List Goals \n   3. Save Goals \n   4. Load Goals \n   5. Record Event \n   6. Quit \nSelect a choice from the menu: ");
            string userInput = Console.ReadLine();
            response = int.Parse(userInput);

            if(response == 1)
            {
                int newResponse;
                Console.Write("\n The types of Goals are: \n   1. Simple Goal \n   2. Eternal Goal \n   3. Checklist Goal \n Which type of goal would you like to create? ");
                string userInput1 = Console.ReadLine();
                newResponse = int.Parse(userInput1);

                if(newResponse == 1)
                {
                    // simple goal
                    Simple simpleGoal1 = new Simple();
                    simpleGoal1.displayIntro();

                    allGoals.Add(simpleGoal1);
                }
                else if(newResponse == 2)
                {
                    // eternal goal
                    Eternal egoal1 = new Eternal();
                    egoal1.displayIntro();

                    allGoals.Add(egoal1);
                }
                else if(newResponse == 3)
                {
                    // checklist goal
                    Checklist checkgoal1 = new Checklist();
                    checkgoal1.displayIntro();
                    checkgoal1.displayBonus();

                    allGoals.Add(checkgoal1);
                }
                else
                {
                    Console.WriteLine("\n Invaild option");
                }

            }
            else if(response == 2)
            {
                //list goals
                Console.WriteLine("The goals are: ");
                for(int i = 0; i < allGoals.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {allGoals[i].GoalsDetails()}");
                }
                
            }
            else if(response == 3)
            {
                //Save goals
                Console.WriteLine("What would you like to name the file? :");
                string saveFile = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(saveFile))
                {
                    // You can add text to the file with the WriteLine method
                    for(int i = 0; i < allGoals.Count; i++)
                    {
                        outputFile.WriteLine($"{i+1}. {allGoals[i].GoalsDetails()}");
                    }
                    
                }
            }
            else if(response == 4)
            {
                //load goals
                Console.WriteLine("What is the filename?");
                string loadFile = Console.ReadLine();

                string[] readfile= System.IO.File.ReadAllLines(loadFile);
                foreach (string line in readfile)
                {
                    string[] parts = line.Split(",");
                    Console.WriteLine(line);
                }
            }
            else if(response == 5)
            {
                // record event
            }
            else if(response == 6){}
            else
            {
                Console.WriteLine("\n Invaild option");
            }
        }
        

    }
}