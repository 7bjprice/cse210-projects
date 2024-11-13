using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new();
        Square square = new(5, "Blue");
        Rectangle rectangle = new(5, 2, "Red");
        Circle circle = new(2, "Green");
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Area: {shape.GetArea()} Color: {shape.GetColor()}");

        }
    }
}