using System;

public abstract class Shape
{
//field
    private string _color;
//constructor
    public Shape(string color)
    {
        _color = color;
    }

//Getter
    public string GetColor()
    {
        return _color;
    }

//setter
    public void SetColor(string color)
    {
        _color = color;
    }
//Step 3- 4 Create a virtual method for GetArea().
    public virtual double GetArea()
    {
        return 0;
    }
       
//     public abstract double GetArea();

// }
}