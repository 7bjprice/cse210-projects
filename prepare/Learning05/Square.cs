public class Square : Shape
{
    // attributes
    private double _side;

    // methods
    public Square(int side, string color) : base(color)
    {
        _color = color;
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}