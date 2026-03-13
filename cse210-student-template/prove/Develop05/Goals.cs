class Goals
{
    protected string _name;
    protected string _desc;
    protected int _pointValue;

    public int getPoints()
    {
        return _pointValue;
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
    virtual public string GoalsDetails()
    {
        return $"[] {_name} ({_desc})";
    }
    virtual public string LoadGoalDetails()
    {
        return $"Goal:{_name},{_desc},{_pointValue}";
    }
    virtual public void IsDone()
    {
        //does nothing
    }
    virtual public int Bonus()
    {
        return 0;
    }
}
