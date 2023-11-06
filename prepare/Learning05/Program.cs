using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", 10);
        Rectangle rectangle = new Rectangle("yellow", 10, 20);
        Circle circle = new Circle("blue", 10);
        List<Shape> shapes = new List<Shape>() 
        {
            square,
            rectangle,
            circle
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}