public class Rectangle : Shape
{
    // attributes
    private double _length;

    private double _width;

    // methods
    public Rectangle(double length, double width, string color) : base(color)
    {

        _length = length;
        _width = width;
        _color = color;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}