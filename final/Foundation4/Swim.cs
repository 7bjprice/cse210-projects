class Swim : Activity
{

    // attributes
    private double _numberLaps;

    // methods
    public Swim(double numberLaps, string date, double durationMinutes) : base(date, durationMinutes)
    {
        _numberLaps = numberLaps;
        _date = date;
        _durationMinutes = durationMinutes;
    }

    public override double CalcSpeed()
    {
        return CalcDistance() / (_durationMinutes / 60);
    }

    public override double CalcDistance()
    {
        return _numberLaps * 50 / 1000;
    }

    public override double CalcPace()
    {
        return 60 / CalcSpeed();
    }
}