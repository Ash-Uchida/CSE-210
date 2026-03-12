class Checklist : Goals
{
    protected int _bonusPoints;
    protected int _bonusPointsValue;
    
    public void displayBonus()
    {
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        string userInput = Console.ReadLine();
        _bonusPoints = int.Parse(userInput);

        Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        string userInput2 = Console.ReadLine();
        _bonusPointsValue = int.Parse(userInput2);
    }
    override public string GoalsDetails()
    {
        return $"[] {_name} ({_desc}) ";
    }
}