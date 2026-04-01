class Address
{
    private string _address;

    //Each venue has a seperate address
    public Address(string address)
    {
        _address = address;
    }

    public string GetAddress()
    {
        return _address;
    }
}