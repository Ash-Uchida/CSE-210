class Outdoors : Event
{
    protected string _weather;
    public Outdoors(string title, string desc, string date, string time, Address address, string weather) 
    : base(title, desc, date, time, address)
    {
        _weather = weather;
    } 
    
    public string TrackWeather()
    {
        return _weather;
    }
    public override string FullDetails() 
    {
        // For receptions this includes an email for RSVP.
        return $"{StandardDetails()}\nType: Outdoors\nWeather: {_weather}";
    }
}