
class Program
{
    static void Main(string[] args)
    {


        Circle tim = new Circle();
        tim.setRadius(50);
        Console.WriteLine(tim.Area());

        Cylinder greg = new Cylinder();
        greg.setRadius(30);
        greg.setHeight(834);
        Console.WriteLine(greg.Area());

        Shere shelby = new Shere();
        shelby.setRadius(13);
        Console.WriteLine(shelby.Area());
    }
}
