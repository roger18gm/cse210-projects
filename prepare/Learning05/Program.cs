using System;

class Program
{
    static void Main(string[] args)
    {
        Square s = new Square("red", 2);
        s.GetColor();
        s.GetArea();

        Rectangle r = new Rectangle("yellow", 2, 4);
        s.GetColor();
        s.GetArea();

        Circle c = new Circle("purple", 3);
        c.GetColor();
        c.GetArea();

        List<Shape> shapes = new List<Shape>();
        shapes.Add(s);
        shapes.Add(r);
        shapes.Add(c);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}");
        }

    }
}