class Receptions : Event
{
    protected bool _rsvp;
    public Receptions(string title, string desc, string date, int time): base(title, desc, date, time)
    {
        //firgure if if we do or dont need stuff here or if we even need this constructor
    } 

    public bool DidYouRsvp()
    {
        return _rsvp;
    }
}