class Event
{
    protected string _title;
    protected string _desc;
    protected string _date; 
    protected int _time;
    protected string _address;

    public Event(string title, string desc, string date, int time)
    {
        _title = title;
        _desc = desc;
        _date = date;
        _time = time;
    }

    //these methods are used for the address and addresss class
    public void SetAddress(string address)
    {
        _address = address;
        //or do we set the address in the address class and call it throught the GetAddresss() method?
        
    }

    public string StandardDetails()
    {
        //figure out what is is that we really want to print out here!!!!
        return $"{_title} {_desc}";
    }
    public string FullDetails()
    {
        //figure out what is is that we really want to print out here!!!!
        return $"{_title} {_desc}";
    }
    public string ShortDesc()
    {
        //figure out what is is that we really want to print out here!!!!
        return $"{_title} {_desc}";
    }
    

}