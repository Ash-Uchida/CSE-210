abstract class Activity
{
    protected string _date;
    protected double _length;
    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }

    public void GetSummary()
    {
        //we return a summary I think?
    }
    abstract public double Distance();
    abstract public double Speed();
    abstract public double Pace();

}
//for extra credit calculate both m/h and km/h --------------------------->