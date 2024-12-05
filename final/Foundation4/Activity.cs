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

    public void DisplaySummary()
    {

    }
}