using System;

public  class Rectangle: Shape
{
 //double because it could be decimal 
    private double _length;
    private double _width;
    
    //constructor that accepts the color and the side
    public Rectangle (string color, double length, double width) : base (color)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _length*_width;
    }

}