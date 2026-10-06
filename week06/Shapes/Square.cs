using System;

public  class Square: Shape
{
 //double because it could be decimal 
    private double _side;
    
    //constructor that accepts the color and the side
    public Square (string color, double side) : base (color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side*_side;
    }

}