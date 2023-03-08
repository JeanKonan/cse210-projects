using System;

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(double lg, double wd): base()
    {
        _length = lg;
        _width = wd;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}