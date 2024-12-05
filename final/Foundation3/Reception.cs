class Reception : Event
{
    // attributes
    private string _weather;

    // methods
    public Reception(string title, string description, string date, string time, string weather) : base(title, description, date, time)
    {
        _eventTitle = title;
        _description = description;
        _date = date;
        _time = time;
        _weather = weather;
    }
    public void DisplayFullDetails()
    {
        Console.WriteLine($"{this.GetType()}: {_eventTitle} {_date} {_time}");
        Console.WriteLine($"{_address.GetFullAddress()}");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"Forecast: {_weather}");
    }
}