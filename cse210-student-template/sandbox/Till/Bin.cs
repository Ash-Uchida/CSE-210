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
    public Bin(string d, double v, int c)
    {
        _denomination = d;
        _value = v;
        _count = c;
    }

    public int getCount()
    {
        return _count;
    }
    public double GetValue()
    {
        return _value;
    }

// if it doesn't return anything it's a void
    public void Transact(int delta)
    {
        _count += delta; //this is now a setter method
    }


}