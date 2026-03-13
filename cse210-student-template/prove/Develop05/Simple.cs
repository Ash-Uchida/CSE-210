class Simple : Goals
{
    protected Boolean _ifCompleted = false;
    override public string GoalsDetails()
    {
                              // condition ? value_if_true : value_if_false;
        string statusSymbol = _ifCompleted ? "X" : "";
        return $"[{statusSymbol}] {_name} ({_desc})";
    }
    override public string LoadGoalDetails()
    {
        return $"SimpleGoal:{_name},{_desc},{_pointValue},{_ifCompleted}";
    }

    public void SetDetails(string name, string desc, int points, bool completed)
    {
        _name = name;
        _desc = desc;
        _pointValue = points;
        _ifCompleted = completed;
    }
    override public void IsDone()
    {
        _ifCompleted = true; // This is the "Update"
    }
}
