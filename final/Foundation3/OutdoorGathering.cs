class OutdoorGathering : Event
{
    // attributes
    private string _rsvpEmail;

     // methods
     public OutdoorGathering(string title, string description, string date, string time, string rsvpEmail) : base(title, description, date, time)
     {
        _eventTitle = title;
        _description = description;
        _date = date;
        _time = time;
        _rsvpEmail = rsvpEmail;
     }
    public void DisplayFullDetails()
    {
        Console.WriteLine($"{this.GetType()}: {_eventTitle} {_date} {_time}");
        Console.WriteLine($"{_address.GetFullAddress()}");
        Console.WriteLine($"{_description}");   
        Console.WriteLine($"RSVP at {_rsvpEmail}");
    }
}