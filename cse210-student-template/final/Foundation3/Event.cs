abstract class Event // 'abstract' prevents someone from making a generic "Event"
{
    protected string _title;
    protected string _desc;
    protected string _date; 
    protected string _time;
    protected Address _address; // Use the Class, not a string

    public Event(string title, string desc, string date, string time, Address address)
    {
        _title = title;
        _desc = desc;
        _date = date;
        _time = time;
        _address = address;
    }

    public string StandardDetails()
    {
       return $"Title: {_title}\nDate: {_date}\nAddress: {_address.GetAddress()}"; 
    }

    // Use 'virtual' so children can change this
    public virtual string FullDetails()
    {
        return StandardDetails(); 
    } 

    public string ShortDesc()
    {
        // this.GetType().Name looks at the name our our class while it's running so we don't need to worry bout it
        return $"{this.GetType().Name}: {_title} ({_date})";
    }
    
}