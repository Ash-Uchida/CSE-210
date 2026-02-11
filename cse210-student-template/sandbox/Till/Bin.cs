using System.Transactions;

class Bin
{
    // FEILDS

    // these are the attributes
    private string _denomination;
    private double _value;
    // float, double, decimal are all options
    private uint _count;
    // uint gives only positive values

    
    // METHODS
    // we need to inistlize using a constructor they are always public
    // Bin is the datatype so we don't need to add datatypes to constructors, like no need for string or int

    // constuctor is inislalizing the values
    public Bin(string d, double v, int c)
    {
        _denomination = d;
        _value = v;
        _count = c;
    }

    public double TotalBinCash() //the getter method
    {
        return _count * _value;
    }

    public void Exchange(int amount)
    {
        if(_count + amount >=0)
        {
            _count += amount;
        }
        else
        {
            string error = "Unable to exchange";
            error += $"not enough {_denomination} in the bin";
        }
    }




