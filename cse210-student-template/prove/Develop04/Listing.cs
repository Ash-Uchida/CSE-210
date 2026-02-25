public class Listing : Activity
{
    protected List<string> _prompts = new List<string> {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
        public Listing(string title, string desc) : base(title, desc)
    {
        // we dont need to call the stuff here cause we did it in activity
    }
    public void ListActivity()
    {
        Timer.Hello();
        Console.WriteLine($"List as many responses you can to the following prompt: \n --- {randPrompt()} ---");
        Console.WriteLine("You may begin in: ");
        Timer.Animation(5);

        int count = 0;
        int time = _duration;
        while (time > 0){            
            Console.ReadLine();
            count += 1;
            time -= 10; 
        };
        Console.WriteLine($"You listed {count} items! \n");
    }
        public string randPrompt()
    {
        // this is where you choose the random prompts
        Random randomGenerator = new();
        int randPrompt = randomGenerator.Next(0, _prompts.Count);

        return _prompts[randPrompt];
    }

}