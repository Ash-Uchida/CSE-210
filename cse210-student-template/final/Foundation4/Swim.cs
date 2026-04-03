class Swim : Activity
{
    protected double _laps;
    public Swim(string date, double length, double laps) : base(date, length)
    {
        _laps = laps;
    }
    override public double DistanceKm()
    {
        return _laps * 50 / 1000; // laps * 50 meters -> km
    }
    override public double Speed()
    {
        return DistanceKm() / (_length / 60); // km/h
    }
    override public double Pace()
    {
        return _length / DistanceKm(); // min/km
    }
    //============================================= Those are the km calcs now lets do the miles calcs
    override public double DistanceMile()
    {
        // Distance (km) = swimming laps * 50 / 1000
        return _laps * 50 / 1000;

        // fix ?
    }
}

