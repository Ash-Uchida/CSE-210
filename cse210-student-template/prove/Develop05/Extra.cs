public class Extra
{
    public static void Animation(int seconds)
    {
        string[] spinner = {"⭑", "˙⋆✮", "⭑", "✶⋆.˚"};
        DateTime end = DateTime.Now.AddSeconds(seconds);

        int i = 0;
        while(DateTime.Now < end)
        {
            Console.Write(spinner[i % spinner.Length]); //this makes it so as i keeps increasing it doesen't get out of the arrays length
            Thread.Sleep(200);
            Console.Write("\b \b"); // Erase the + character
            i++;
        }
        Console.WriteLine(); 

    }
    
}
