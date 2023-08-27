public abstract class Shape
{
    public abstract double CalculateArea();
}


public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}


public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}


using System;

class shape_abstract
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5);
        double circleArea = circle.CalculateArea();
        Console.WriteLine($"Circle Area: {circleArea:F2}");

        Rectangle rectangle = new Rectangle(4, 6);
        double rectangleArea = rectangle.CalculateArea();
        Console.WriteLine($"Rectangle Area: {rectangleArea:F2}");
    }
}
