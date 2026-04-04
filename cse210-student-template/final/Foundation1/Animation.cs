public class Animation
{
    // we are going to make a animation that counts down to when the the vids info is about to show, 3..2..1..
    public static void CountDown(int seconds)
    {
        Console.WriteLine("Youtube vid info: \n");

        for(int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            
        }
        Console.WriteLine();

    }
}

// this is for extra credit