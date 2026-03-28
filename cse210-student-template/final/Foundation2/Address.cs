public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    
    public bool IsUsa()
    {
        // this is to just check if they are from the usa and we can call this method in the other classes
        if(_country.ToLower() == "usa")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string FullAddress()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }
}

