class Outdoors : Event
{
    protected List<string> _weather = new List<string>{"Sunny", "Partly Cloudy", "Cloudy", "Overcast","Raining", "Drizzle", "Thunderstorm","Snowing", "Blizzard", "Sleet", "Hail", "Windy", "Breezy", "Foggy", "Misty", "Hot", "Cold", "Freezing", "Humid", "Dry", "Clear", "Stormy"};
    public Outdoors(string title, string desc, string date, string time, Address address) 
    : base(title, desc, date, time, address)
    {
        //we dont need this cause the _weather varible is only used in this class and not something we retriving from somewhere
    } 

    public string RandWeather()
    {
        // we choose a random index from the list
        Random random = new();
        int weatherIndex = random.Next(0,_weather.Count);
        return _weather[weatherIndex];
    }
    
    public override string FullDetails() 
    {
        // For receptions this includes an email for RSVP.
        return $"{StandardDetails()}\nType: Outdoors\nWeather: {RandWeather()}";
    }
}

// for extra credit add randomized weather because wether is random, this predicts what the weather is 
// and allows you to change your descion depending on the chaning weather predictions