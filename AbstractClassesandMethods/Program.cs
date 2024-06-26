﻿public abstract class Shape
{
    public abstract double GetArea();
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
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

    public override double GetArea()
    {
        return Width * Height;
    }
}

public class Program
{
    public static void Main()
    {
        Circle circle = new Circle(7);
        Rectangle rectangle = new Rectangle(5, 6);

        Console.WriteLine($"Circle Area: {circle.GetArea()}");       
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}"); 
    }
}
