abstract class Activity
{
    protected string _date;
    protected double _length;
    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }

    abstract public double DistanceKm();
    abstract public double Speed();
    abstract public double Pace();
    //============================================= Those are the km calcs now lets do the miles calcs
    abstract public double DistanceMile();

    public string GetSummary()
    {
        // NOTE: This method should CALL the abstract methods, not calculate itself
        string summary = $"\n--------------------------\nDate: {_date}\nActivity: {this.GetType().Name}\nLength: {_length} minutes";

        //The summary for km
        summary += $"\n\nDistance:{Math.Round(DistanceKm(), 2)} km, Speed:{Math.Round(Speed(),2)} kph, Pace:{Math.Round(Pace(),2)} min/km\n";
        // The summary for miles
        summary += $"Distance:{Math.Round(DistanceMile(), 2)} miles, Speed:{Math.Round(Speed(),2)} mph, Pace:{Math.Round(Pace(),2)} min/mile\n--------------------------\n";

        return summary;
    }

}
//for extra credit calculate both m/h and km/h --------------------------->