class Run : Activity
{
    // attributes
    private double _distance;

    // methods
    public Run(double distance, string date, double durationMinutes) : base(date, durationMinutes)
    {
        _distance = distance;
        _date = date;
        _durationMinutes = durationMinutes;
    }

    public override double CalcSpeed()
    {
        return _distance / (_durationMinutes / 60);
    }

    public override double CalcDistance()
    {
        return _distance;
    }

    public override double CalcPace()
    {
        return _durationMinutes / _distance;
    }
}