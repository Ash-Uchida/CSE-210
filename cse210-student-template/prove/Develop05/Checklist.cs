class Checklist : Goals
{
    protected int _bonusPoints;
    protected int _bonusPointsValue;
    protected int _numCompleted = 0;
    
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
                                         // condition ? value_if_true : value_if_false;
        string statusSymbol = (_numCompleted >= _bonusPoints)? "X" : "";
        return $"[{statusSymbol}] {_name} ({_desc}) -- Currently completed: {_numCompleted} / {_bonusPoints}";
    }
    override public string LoadGoalDetails()
    {
        return $"ChecklistGoal:{_name},{_desc},{_pointValue},{_bonusPoints},{_bonusPointsValue},{_numCompleted}";
    }
    public void SetDetails(string name, string desc, int points, int bonus, int bonusValue, int completed)
    {
        _name = name;
        _desc = desc;
        _pointValue = points;
        _bonusPoints = bonus;
        _bonusPointsValue = bonusValue;
        _numCompleted = completed;
    }
    override public void IsDone()
    {
        // This is the "Update"
        _numCompleted ++;

    }
    override public int Bonus()
    {
        if(_numCompleted == _bonusPoints)
        {
            Console.WriteLine($"Congrats! You earned the bonus of {_bonusPointsValue}");
            return _bonusPointsValue;
        }
        return 0;
    }
}