public class Breathing : Activity
{
    // the constructor
    public Breathing(string title, string desc) : base(title, desc)
    {
        // we dont need to call the stuff here cause we did it in activity
    }

    public void BreathingActivity()
    {
        Timer.Hello();   
        int time = _duration;

        while (time > 0){            
            // we then do the breathing
            Console.WriteLine("Breath in...");
            Timer.Animation(5);
            Console.WriteLine("Breath out...");
            Timer.Animation(5);

            Console.WriteLine("");
            time -= 10; 
        };
        
    }

    
}