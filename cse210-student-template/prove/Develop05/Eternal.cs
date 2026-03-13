class Eternal : Goals
{
    override public string GoalsDetails()
    {
        return $"[] {_name} ({_desc})";
    }
    override public string LoadGoalDetails()
    {
        return $"EternalGoal:{_name},{_desc},{_pointValue}";
    }
    public void SetDetails(string name, string desc, int points)
    {
        _name = name;
        _desc = desc;
        _pointValue = points;
    }

}