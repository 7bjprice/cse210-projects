class Event
{
    // attributes
    protected string _eventTitle;

    protected string _description;

    protected string _date; 

    protected string _time;

    protected Address _address;

    // methods
    public Event(string title, string description, string date, string time)
    {
        _eventTitle = title;
        _description = description;
        _date = date;
        _time = time;

    }

    public void CreateAddress(string streeAddress, string city, string state, string country="United States")
    {
        Address newAddress = new(streeAddress, city, state, country);
        _address = newAddress;
    }
    public void DisplayStandardDetails()
    {
        Console.WriteLine($"{_eventTitle} {_date} {_time} \n{_address.GetFullAddress()}\n> {_description}");
    }

    public void DisplayShortDescription()
    {
        
        Console.WriteLine($"{this.GetType().Name}: {_eventTitle} {_date}");
    }
}