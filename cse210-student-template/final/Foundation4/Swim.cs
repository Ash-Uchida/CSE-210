class Swim : Activity
{
    protected double _laps;
    public Swim(string date, double length, double laps) : base(date, length)
    {
        _laps = laps;
    }
    override public double DistanceKm()
    {
        return _laps * 50 / 1000; // the formula they gave
    }
    override public double SpeedKm()
    {
        return DistanceKm() / (_length / 60); // km/h
    }
    override public double PaceKm()
    {
        return _length / DistanceKm(); // min/km
    }
    //============================================= Those are the km calcs now lets do the miles calcs
    override public double DistanceMile()
    {
        return _laps * 50 / 1000 * 0.62; //swimming laps * 50 / 1000 * 0.62
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

