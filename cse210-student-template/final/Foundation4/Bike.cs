class Bike : Activity
{
    protected double _speed;
    public Bike(string date, double length, double speed) : base(date, length)
    {
        _speed = speed;
    }
    override public double DistanceKm()
    {
        return _speed * (_length / 60); // km/h * hours = km
    }
    override public double Speed()
    {
        return _speed; // km/h
    }
    override public double Pace()
    {
        return _length / DistanceKm(); // min/km
    }
    //============================================= Those are the km calcs now lets do the miles calcs

    override public double DistanceMile()
    {
        return 0;
    }

}
