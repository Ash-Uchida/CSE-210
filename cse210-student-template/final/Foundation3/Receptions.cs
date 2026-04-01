class Receptions : Event
{
    protected bool _rsvp;
    protected string _email;
    public Receptions(string title, string desc, string date, string time, Address address, bool rsvp, string email) 
    : base(title, desc, date, time, address)
    {
       _rsvp = rsvp;
       _email = email;
    } 

    public bool DidYouRsvp()
    {
        return _rsvp;
    }
    public override string FullDetails() 
    {
        // For receptions this includes an email for RSVP.
        return $"{StandardDetails()}\nType: Reception\nDid they RSVP: {_rsvp}\nEmail: {_email}";
    }
}


    
