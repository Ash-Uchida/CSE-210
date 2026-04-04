abstract class Event 
{
    protected string _title;
    protected string _desc;
    protected string _date; 
    protected string _time;
    protected Address _address; // Useing to from address class

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
       return $"Title: {_title}\nDescription: {_desc}\nDate: {_date}\nTime: {_time}\nAddress: {_address.GetAddress()}"; 
    }

    //children can change this
    public abstract string FullDetails();

    public string ShortDesc()
    {
        // this.GetType().Name looks at the name our our class while it's running so we don't need to worry bout it
        return $"{this.GetType().Name}: {_title} ({_date})";
    }
    
}