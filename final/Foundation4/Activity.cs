abstract class Activity
{
    // attributes
    protected string _date;

    protected double _durationMinutes;

    // methods
    public Activity(string date, double durationMinutes)
    {
        _date = date;
        _durationMinutes = durationMinutes;
    }

    public abstract double CalcSpeed();

    public abstract double CalcDistance();

    public abstract double CalcPace();

    public string GetSummary()
    {
        return $"{_date,-15} {this.GetType().Name,-4} ({_durationMinutes} min): Distance {CalcDistance(),4} km, Speed: {CalcSpeed(),3} kph, Pace: {CalcPace(),3} min per km";
    }
}