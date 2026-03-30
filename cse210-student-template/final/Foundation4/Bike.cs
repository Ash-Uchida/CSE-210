class Bike : Activity
{
    protected double _speed;
    public Bike(string date, double length) : base(date, length)
    {
        //dont think we need stuff here
    }
    override public double Distance()
    {
        return 0;
    }
    override public double Speed()
    {
        return 0;
    }
    override public double Pace()
    {
        return 0;
    }
}
//for extra credit calculate both m/h and km/h --------------------------->