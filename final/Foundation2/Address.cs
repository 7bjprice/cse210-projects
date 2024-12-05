class Address
{
    // attributes
    private string _streetAddress;

    private string _city;

    private string _country;

    private string _state;

    // methods
    public Address(string streeAddress, string city, string state, string country)
    {
        _streetAddress = streeAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool GetIsDomestic()
    {
        return _country == "United States" || _country == "USA";
    }

    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_state} {_country}";
    }
}