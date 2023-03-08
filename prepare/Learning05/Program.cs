using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> myShapes = new List<Shape>();

        myShapes.Add(new Square(5));
        myShapes.Add(new Circle(5));
        myShapes.Add(new Rectangle(10,5));

        myShapes[0].SetColor("Blue");
        myShapes[1].SetColor("Yellow");
        myShapes[2].SetColor("Red");

        foreach (Shape shape in myShapes)
        {
            Console.WriteLine($"The area of your shape is: {shape.GetArea()}");   
        }
    }
}