public class Reflecting : Activity
{
    public List<string> _prompts = new List<string> {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    public List<string> _reflect = new List<string> {"Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
    public Reflecting(string title, string desc) : base(title, desc)
    {
        // we dont need to call the stuff here cause we did it in activity
    }
    public void ReflectingActivity()
    {
        Timer.Hello();
        Console.WriteLine($"Consider the following prompt: \n --- {randPrompt()} ---");

        Console.WriteLine("When you have something in mind press Enter"); 
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine("You may begin in");
        Timer.Animation(5);

        int time = _duration;
        while (time > 0){            
            Console.WriteLine(randReflect());
            Timer.Animation(10);
            Console.WriteLine("");
            time -= 10; 
        };
        
    }
    public string randPrompt()
    {
        // this is where you choose the random prompts
        Random randomGenerator = new();
        int randPrompt = randomGenerator.Next(0, _prompts.Count);

        return _prompts[randPrompt];
    }
    public string randReflect()
    {
        Random randomGenerator = new();
        int randPrompt = randomGenerator.Next(0, _reflect.Count);

        return _reflect[randPrompt];
    }

}