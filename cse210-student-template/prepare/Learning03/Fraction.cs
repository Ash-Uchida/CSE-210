// The class should have two attributes for the top and bottom numbers.
// Make sure the attributes are private
class Fraction {
    private int _top;
    private int _bottom;

    public Fraction()
    {
        // Constructor that has no parameters that initializes the number to 1/1.
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int topNumber)
    {
        // Constructor that has one parameter for the top and that initializes the denominator to 1. 
        // So that if you pass in the number 5, the fraction would be initialized to 5/1.
        _top = topNumber;
        _bottom = 1;
        
    }
    public Fraction(int topNumber,int bottomNumber)
    {
    // Constructor that has two parameters, one for the top and one for the bottom.
        _top = topNumber;
        _bottom = bottomNumber;
 
    }
// --------------------------------------------------> 
// these are my getter and setter methods as our "gatekeepers" for our methods cause they're private -> encapsulated
// Without Getters: Other classes would have no way to know what the fraction currently is.
// Without Setters: Other classes would have no way to update the fraction once it's created.

    // -----------> setters
    // setTop(top : int)
    public void setTop(int top)
    {
        _top = top;
    }
    // setBottom(bottom : int() but bottom can't be 0
    public void setBottom(int bottom)
    {
        if(bottom != 0)
        {
            _bottom = bottom;
        }
        else
        {
             _bottom = 1;
        }
        
    }
    // ----------> getters
        // getTop()
    public int getTop()
    {
        return _top;
    }
    // getBottom()
    public int getBottom()
    {
        return _bottom;
    }

// --------------------------------------------------->
    // these are the calculation methods that are getting called in program.cs
    public string getFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }
    public double getDecimalValue()
    {
        return (double)_top / (double)_bottom;;
    }

}

