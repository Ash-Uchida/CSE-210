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
    override public double Speed()
    {
        return _distance / (_length / 60); // distance / hours = km/h
    }
    override public double Pace()
    {
        return _length / _distance; // minutes / km
    }
    //============================================= Those are the km calcs now lets do the miles calcs
    override public double DistanceMile()
    {
        return 0;
    }
}
