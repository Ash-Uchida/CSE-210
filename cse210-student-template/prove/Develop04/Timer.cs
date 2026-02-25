public class Timer
{

    public static void Hello()
    {
        Console.WriteLine("\n Get Ready... \n ");
        Animation(7);
    }
    public static void Animation(int seconds)
    {
        for(int i = seconds; i >0; i--)
        {
            
            Console.Write("+");
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character
        }
        Console.WriteLine(); 
    }

    public static void extraCredit(int seconds)
    {
        string[] spinner = {"|", "/", "-", "\\"};
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
    public static void Secret(int seconds)
    {
        Console.WriteLine("Press this Link : https://www.youtube.com/watch?v=dQw4w9WgXcQ ");
    }


}