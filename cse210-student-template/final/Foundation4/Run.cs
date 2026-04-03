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
        // Speed:km/h = (distance / minutes) * 60
        double speed = _distance / _length;
        return speed * 60;
    }
    override public double PaceKm()
    {
        // min/km
        return _length / _distance;
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