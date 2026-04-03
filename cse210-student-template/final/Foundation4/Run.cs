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
        // Speed = 60 / pace
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
        return 0;
    }
}
