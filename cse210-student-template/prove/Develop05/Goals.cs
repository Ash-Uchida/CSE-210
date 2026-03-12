abstract class Goals
{
    protected string _name;
    protected string _desc;
    protected int _pointValue;

    public string displayPoints()
    {
        return $"You have {_pointValue} points";
    }
    public void displayIntro()
    {
        Console.WriteLine("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.WriteLine("What is a short description of your goal? ");
        _desc = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal? ");
        string userInput = Console.ReadLine();
        _pointValue = int.Parse(userInput);

    }
    abstract public string GoalsDetails();

}
