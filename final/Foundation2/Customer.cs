using System.Net.Sockets;

class Customer
{
    // attributes
    private string _name;

    private Address _address;

    // methods
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.GetFullAddress();
    }
    public bool isDomestic()
    {
        return _address.GetIsDomestic();
    }
}