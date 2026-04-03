abstract class Activity
{
    protected string _date;
    protected double _length;
    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }

    public string GetSummary()
    {
        // NOTE: This method should CALL the abstract methods, not calculate itself
        string summary = $"\n--------------------------\nDate: {_date}\nActivity: {this.GetType().Name}\nLength: {_length} minutes";

        //I dunno this just don't look quite right
        summary += $"\n\nDistance:{Math.Round(DistanceKm(), 2)} km, Speed:{Math.Round(SpeedKm(),2)} km/h, Pace:{Math.Round(PaceKm(),2)} min/km\n--------------------------\n";

        return summary;
    }
    abstract public double DistanceKm();
    abstract public double SpeedKm();
    abstract public double PaceKm();
    //============================================= Those are the km calcs now lets do the miles calcs

    abstract public double DistanceMile();
    abstract public double SpeedMile();
    abstract public double PaceMile();

}
//for extra credit calculate both m/h and km/h --------------------------->