using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal1 = new Journal();

        // we want the actually program to run here
        Console.WriteLine("Welcome to the Journal Program!");
        int response;
        do
        {
            Console.WriteLine("Please select one of the following choices: \n 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit");
            Console.Write("What would you like to do? ");
            string userInput = Console.ReadLine();
            response = int.Parse(userInput);

            // ===============================================================
            // The Write function: 1

            // When option one is chosen we print out a random prompt : DONE
            // Then we get the user input : DONE
            // save the prompt and response to a list : DONE
            // date time : DONE

            if (response == 1)
            {
                string prompt = journal1.RandomPrompt();
                Console.WriteLine(prompt);
                string promptResponse = Console.ReadLine();
                DateTime timeNow = DateTime.Now;

                journal1.addEntry(prompt, promptResponse, timeNow);
                Console.WriteLine();

            }

            // ===============================================================
            // The Display function: 2

            // Shows what you have written in the Write function, but not what's been saved in txt files : DONE

            else if (response == 2)
            {
                journal1.Display();
                Console.WriteLine();
            }

            // ===============================================================
            // The Load function: 3

            // Asks user for a txt file name : DONE
            // displays what's in the txt file : DONE
            else if (response == 3)
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();

                string readfile = File.ReadAllText(filename);
                Console.WriteLine(readfile);
            }


            // ===============================================================
            // The Save function: 4

            // Asks what we want to name it as : DONE
            // Saves it into a txt file : DONE
            // Saves it as Date + Prompt + input : DONE
            else if (response == 4)
            {
                Console.WriteLine("What would you like to name the file?");
                string filename = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    // this is calling my journal.cs that should return a string of our stuff
                    outputFile.WriteLine(journal1.Input());
                    // pretty sure this is another way to write to the file probs
                    // File.AppendText(journal1.Input());
                    // accutlly this appends to the end of the file, but i don't need it
                }
            }

            // ===============================================================

            else
            {
                Console.WriteLine();
            }


        } while (response != 5);


    }


}

