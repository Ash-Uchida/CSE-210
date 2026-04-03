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
    override public double Speed()
    {
        return _speed;
    }
    override public double Pace()
    {
        // Pace = 60 / speed
        return 60 / Speed();
    }
    //============================================= Those are the km calcs now lets do the miles calcs

    override public double DistanceMile()
    {
        return 0;
    }

}
