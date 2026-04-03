class Bike : Activity
{
    protected double _speed;
    public Bike(string date, double length, double speed) : base(date, length)
    {
        _speed = speed;
    }
    override public double DistanceKm()
    {
        // Distance = speed: km/h * length: mins
        return _speed * (_length/60);
    }
    override public double SpeedKm()
    {
        return _speed;
    }
    override public double PaceKm()
    {
        // Pace = minutes / distance
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
