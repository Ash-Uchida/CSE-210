public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public Boolean IsInUSA()
    {
        return _address.IsUsa();
    }
    public string GetAddress()
    {
        return $"Name: {_name} \nAddress: {_address.FullAddress()}";
    }
    public string GetName()
    {
        return _name;
    }
 
}

