public class Fraction
{
    private int _top;
    private int _bottom;
    
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        Console.Write("Enter the numerator: ");
        _top = int.Parse(Console.ReadLine());
        
    }
    public int GetBottom()
    {
       return _bottom;
    }

    public void SetBottom(int bottom)
    {
        Console.Write("Enter the denominator: ");
        _bottom = int.Parse(Console.ReadLine());
    }
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue()
        {
        return (double) _top / _bottom;
    }
}