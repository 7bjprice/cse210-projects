class Lecture : Event
{
    // attributes

    private string _speaker;

    private int _capacity;

    // methods
    public Lecture(string title, string description, string date, string time, string speaker, int capacity) : base(title, description, date, time)
    {
        _eventTitle = title;
        _description = description;
        _date = date;
        _time = time;
        _speaker = speaker;
        _capacity = capacity;

    }
    public void DisplayFullDetails()
    {
        Console.WriteLine($"{this.GetType()}: {_eventTitle} {_date} {_time}");
        Console.WriteLine($"{_address.GetFullAddress()}");
        Console.WriteLine($"{_speaker} | Capacity: {_capacity}");
        Console.WriteLine($"{_description}");
    }
}