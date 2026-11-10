using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("navy", 3.14);
        Console.WriteLine($"{square.GetColor()} {square.GetArea()}");
        Rectangle rectangle = new Rectangle("white", 6.25, 5.1);
        Console.WriteLine($"{rectangle.GetColor()} {rectangle.GetArea()}");
        Circle circle = new Circle("brown", 8.91);
        Console.WriteLine($"{circle.GetColor()} {circle.GetArea()}");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetColor()} {shape.GetArea()}");
        }
    }
}