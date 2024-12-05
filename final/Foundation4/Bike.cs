class Bike : Activity
{
    // attributes
    private double _speed;

    // methods
    public Bike(double speed, string date, double durationMinutes) : base(date, durationMinutes)
    {
        _speed = speed;
        _date = date;
        _durationMinutes = durationMinutes;
    }

    public override double CalcSpeed()
    {
        return _speed;
    }

    public override double CalcDistance()
    {
        return _speed * _durationMinutes / 60;
    }

    public override double CalcPace()
    {
        return 60 / _speed;
    }
}