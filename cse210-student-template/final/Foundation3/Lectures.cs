class Lectures : Event
{
    private string _speaker;
    private int _capacity;

    // Pass the basics to 'base', set the specifics here
    public Lectures(string title, string desc, string date, string time, Address address, string speaker, int capacity) 
    : base(title, desc, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    } 

    public override string FullDetails() 
    {
        return $"{StandardDetails()}\nType: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}