class Event
{
    protected string _title;
    protected string _desc;
    protected string _date; 
    protected int _time;
    protected string _address;
    protected string _type; //we need this right?

    public Event(string title, string desc, string date, int time, string type)
    {
        _title = title;
        _desc = desc;
        _date = date;
        _time = time;
        _type = type;
    }

    //these methods are used for the address and addresss class
    public void SetAddress(string address)
    {
        _address = address;
        //or do we set the address in the address class and call it throught the GetAddresss() method?
        
    }

    public string StandardDetails()
    {
        //Standard details - Lists the title, description, date, time, and address.
        return $"Title:{_title} \nDescription:{_desc} \nDate{_date} \nTime{_time} \nAddress:{_address}";
    }
    public string FullDetails()
    {
        //Full details - Lists all of the above, plus type of event and information specific to that event type. 
        string details = $"Title:{_title} \nDescription:{_desc} \nDate{_date} \nTime{_time} \nAddress:{_address}";

        string type = $"type of event";
        if(type == "Lectures")
        {
            details += $"For lectures, this includes the speaker name and capacity. ";
        }
        else if(type == "Receptions")
        {
            details += $"For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather.";
        }

        return $"{type}\n{details}";
    }
    public string ShortDesc()
    {
        //Short description - Lists the type of event, title, and the date.
        return $"{_type} \nTitle:{_title} \nDate:{_date}";
    }
    

}