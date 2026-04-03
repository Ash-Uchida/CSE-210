class Swim : Activity
{
    protected double _laps;
    public Swim(string date, double length, double laps) : base(date, length)
    {
        _laps = laps;
    }
    override public double DistanceKm()
    {
        // Distance (km) = swimming laps * 50 / 1000
        return _laps * 50 /1000;
    }
    override public double Speed()
    {
        //Speed = 60 / pace
        return 60 / Pace();
    }
    override public double Pace()
    {
        // Pace = 60 / speed
        return 60 / Speed();
    }
    //============================================= Those are the km calcs now lets do the miles calcs
    override public double DistanceMile()
    {
        // Distance (km) = swimming laps * 50 / 1000
        return _laps * 50 / 1000;
    }
}

