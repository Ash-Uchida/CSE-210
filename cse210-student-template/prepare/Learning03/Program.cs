using System;

class Program
{
    static void Main(string[] args)
    {
        // these are the tests
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.getFractionString());
        Console.WriteLine(fraction1.getDecimalValue());

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.getFractionString());
        Console.WriteLine(fraction2.getDecimalValue());

        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.getFractionString());
        Console.WriteLine(fraction3.getDecimalValue());

        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction4.getFractionString());
        Console.WriteLine(fraction4.getDecimalValue());

        // -----------------------------------------------
        Random random = new Random();
        Fraction fraction5 = new Fraction();
        for(int i=0; i<20; i++)
        {
            // generating the random nums
            int newTop = random.Next(1,11);
            int newBottom = random.Next(1,11);

            // updating the new nums to the random nums
            fraction5.setTop(newTop);
            fraction5.setBottom(newBottom);

            // Now display the results
            // the i+1 shows the index value
            Console.Write($"Fraction {i +1}: ");
            Console.Write($"String {fraction5.getFractionString()} ");
            Console.WriteLine($"Decimal {fraction5.getDecimalValue()} ");
        }
    }
}