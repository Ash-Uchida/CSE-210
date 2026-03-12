class Circle : RoundShape
{
    protected double _radius;

    public double getRadius()
    {
        return _radius;
    }
    public void setRadius(double r)
    {
        _radius = r;
    }

    override public double Area()
    {
        return Math.PI * _radius * _radius;
    }
}