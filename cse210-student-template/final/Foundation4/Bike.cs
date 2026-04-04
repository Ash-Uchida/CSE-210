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
    override public double SpeedKm()
    {
        return _speed; // km/h
    }
    override public double PaceKm()
    {
        return _length / DistanceKm(); // min/km
    }
    //============================================= Those are the km calcs now lets do the miles calcs

    override public double DistanceMile()
    {
        return DistanceKm() * 0.621371; //miles=kilometers×0.621371
    }
    override public double SpeedMile()
    {
        return SpeedKm() * 0.621371; //mph=km/h×0.621371
    }
    override public double PaceMile()
    {
        return PaceKm() * 1.60934; //min/mile = min/km×1.60934
    }

}
