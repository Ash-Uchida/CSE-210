class Lectures : Event
{
    protected string _speaker;
    protected int _capacity;

    public Lectures(string title, string desc, string date, int time, string type): base(title, desc, date, time,type)
    {
        //firgure if if we do or dont need stuff here or if we even need this constructor
    } 

    public int MaxCapacity()
    {
        return _capacity;

    }
    public string Speaker()
    {
        return _speaker;
    }
}