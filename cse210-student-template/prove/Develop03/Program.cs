using System;
class Program
{
    static void Main(string[] args)
    {
        // first we create a Reference
        Reference reference1 = new Reference("Proverbs", 3, 5);
        Reference reference2 = new Reference("Proverbs", 3, 6);
        // then we also need to create a Scripture
        Scriptures scripture1 = new Scriptures(reference1, "Trust in the Lord with all thine heart; and lean not unto thine own understanding.");
        Scriptures scripture2 = new Scriptures(reference2,"In all thy ways acknowledge him, and he shall direct thy paths.");


        Console.WriteLine("Welcome to the Scripture Memorizer!");
        string response = "";
        do
        {
            Console.Clear();
            // call the reference and scripture
            scripture1.Display();
            scripture2.Display();

            // the extra credit
            Console.Write($"\nThe number of words remaining: {scripture1.NumLeft() + scripture2.NumLeft()}");
            Console.WriteLine("       Press enter to continue or type 'quit' to finish: ");
            string userInput = Console.ReadLine();
            response = userInput; 


            if(scripture1.AllWordsHidden() && scripture2.AllWordsHidden())
            {
                break;
            }
            // now we need
            //  to call scripture methods that makes the words disapear
            scripture1.HideRandomWords(); 
            scripture2.HideRandomWords(); 
        
        }while(response.ToLower() != "quit");
    }
}