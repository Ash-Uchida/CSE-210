class Swim : Activity
{
    protected double _laps;
    public Swim(string date, double length, double laps) : base(date, length)
    {
        _laps = laps;
    }
    override public double DistanceKm()
    {
        // 50 meters per lap and then divided by 1000 then converts it to km
        return _laps * 50 /1000;
    }
    override public double SpeedKm()
    {
        //Speed = (distance / minutes) * 60
        double speed = DistanceKm() / _length;
        return speed * 60;
    }
    override public double PaceKm()
    {
        // TODO: Pace = minutes / distance
        return _length / DistanceKm();
    }
    //============================================= Those are the km calcs now lets do the miles calcs
    override public double DistanceMile()
    {
        return 0;
    }
    override public double SpeedMile()
    {
        return 0;
    }
    override public double PaceMile()
    {
        return 0; 
    }
}

//for extra credit calculate both m/h and km/h --------------------------->