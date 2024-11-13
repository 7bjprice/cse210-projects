public class Circle : Shape
{
    // attributes
    private double _radius;

    // methods
    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
        _color = color;
    }

    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}