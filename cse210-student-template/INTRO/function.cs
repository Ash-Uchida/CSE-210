returnType FunctionName(dataType parameter1, dataType parameter2)
{
    // function_body
}

void DisplayPersonalMessage(string userName)
{
    Console.WriteLine($"Hello {userName}");
}

int AddNumbers(int first, int second)
{
    int sum = first + second;
    return sum;
}

// To define a standalone function in C#, use the static keyword before the return type:
// Use static for all of your functions until we start writing classes.
static void DisplayMessage()
{
    Console.WriteLine("Hello world!");
}

static void DisplayPersonalMessage(string userName)
{
    Console.WriteLine($"Hello {userName}");
}

static int AddNumbers(int first, int second)
{
    int sum = first + second;
    return sum;
}

// C# Value types include: int, float, double, bool, char, enum, and struct.


static void TestPassReferenceType(int[] data)
{
    data[2] = 1099;
    ...   
}
public static void Main(string[] args)
{
    int[] dataArray;
    dataArray = new int[] { 10, 20, 30 };
    TestPassReferenceType(dataArray);
    foreach (int y in dataArray)
        Console.WriteLine(y);
    ...
}

// ------------------------------------------

static void TestPassByReferenceUsingRef(ref int x)
{
    x = 99;
    ...   
}
public static void Main(string[] args)
{
    int x = 10;
    TestPassByReferenceUsingRef(ref x);
    Console.WriteLine(x);
    ...
}
// --------------------------------------------

static void TestPassByReferenceUsingOut(out int x)
{
    x = 199;
    ...   
}
public static void Main(string[] args)
{
    int x;
    TestPassByReferenceUsingRef(out x);
    Console.WriteLine(x);
    ...
}

//handling exceptions-------------------------------------

using System;

class Program
{
    static void Main()
    {
        try
        {
            // Attempt to divide by zero
            int numerator = 10;
            int denominator = 0;
            int result = numerator / denominator;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException ex)  //Handle only divide by 0 exception
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            Console.WriteLine("Exception message: " + ex.Message);
        }
        catch (Exception ex)  // Catches all other exceptions
        {
            Console.WriteLine("Error: Exception Occurred");
            Console.WriteLine("Exception message: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("This block always executes, regardless of exceptions.");
        }
    }
}
