class Run : Activity
{
    protected double _distance;

    public Run(string date, double length, double distance) : base(date, length)
    {
        _distance = distance;
    }
    override public double DistanceKm()
    {
        return _distance;
    }
    override public double SpeedKm()
    {
        return _distance / (_length / 60); // distance / hours = km/h
    }
    override public double PaceKm()
    {
        return _length / _distance; // minutes / km
    }
    //============================================= Those are the km calcs now lets do the miles calcs
    override public double DistanceMile()
    {
        return DistanceKm() * 0.621371; //same as bike calc
    }
    override public double SpeedMile()
    {
        return SpeedKm() * 0.621371;
    }
    override public double PaceMile()
    {
        return PaceKm() * 1.60934;
    }
}
