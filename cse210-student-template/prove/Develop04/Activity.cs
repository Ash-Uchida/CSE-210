public class Activity
{
    protected string _title; 
    protected string _desc;
    protected int _duration;
    protected int _totalTime; 

    // the constructor
    public Activity(string title, string desc)
    {
        _title = title;
        _desc = desc;
    }

    // the methods
    public void Intro()
    {
        Console.WriteLine($" \n Welcome to the {_title} Activity. \n \n {_desc} \n");
    }
    public void GetDuration()
    {
        // the user input for duration
        Console.Write("How long, in seconds would you like your session? ");
        string userInput = Console.ReadLine();
        _duration = int.Parse(userInput);
        _totalTime = _duration;
    }
    public void Outro()
    {
        Console.WriteLine($"Well Done! \n You have completed {_totalTime} seconds of the {_title} Activity");
    }
}