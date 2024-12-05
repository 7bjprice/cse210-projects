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
        
    }

    public override double CalcDistance()
    {

    }

    public override double CalcPace()
    {

    }
}