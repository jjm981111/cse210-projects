using System;

class Program
{
    static void Main(string[] args)
    {
         List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 3);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 4, 5);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 6);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
    }
    }
}

public abstract class Shape {
    private string _color;

    public Shape(string color){
        _color = color;
    }

    public string GetColor(){
        return _color;
    }

    public void SetColor(string color){
        _color = color;
    }

    public abstract double GetArea();
}

class Square: Shape {
    private double _side;

    public Square (string color, int side): base(color){
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}

class Rectangle: Shape {
    private double _width;
    private double _high;

    public Rectangle (string color, int width, int high): base(color){
        _width = width;
        _high = high;
    }

    public override double GetArea()
    {
        return _width*_high;
    }
}

class Circle: Shape {
    private double _radius;

    public Circle (string color, int radius): base(color){
        _radius = radius;
    }

    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}