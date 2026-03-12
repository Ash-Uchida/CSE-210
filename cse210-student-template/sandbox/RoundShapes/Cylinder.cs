
class Cylinder : Circle
{
    private double _height;

    public double getHeight()
    {
        return _height;
    }
    public void setHeight(double h)
    {
        _height = h;
    }

    override public double Area()
    {
        return Math.PI * _radius * (_radius + _height) * 2 ;
    }
}