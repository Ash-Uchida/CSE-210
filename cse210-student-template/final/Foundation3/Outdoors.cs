class Outdoors : Event
{
    public string _weather;
    public Outdoors(string title, string desc, string date, int time): base(title, desc, date, time)
    {
        //firgure if if we do or dont need stuff here or if we even need this constructor
    } 
    
    public string TrackWeather()
    {
        return _weather;
    }
}