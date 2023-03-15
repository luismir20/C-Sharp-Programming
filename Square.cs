using System;

class Square
{
    private double side;

    public Square(double side)
    {
        this.side = side;
    }

    public double GetArea()
    {
        return side * side;
    }

    public double GetPerimeter()
    {
        return 4 * side;
    }

    public void Display()
    {
        Console.WriteLine("Side length: {0}", side);
        Console.WriteLine("Area: {0}", GetArea());
        Console.WriteLine("Perimeter: {0}", GetPerimeter());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Square mySquare = new Square(5.0);
        mySquare.Display();
        Console.ReadKey();
    }
}
