using System;

class Program
{
    static void Main(string[] args)
    {
        //STEP7 creating the list
        List<Shape> shapes = new List<Shape>();
        
        Square s1 = new Square("Blue", 7);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Yellow", 2, 4);
        shapes.Add(s2);
        // Console.WriteLine(s2.GetColor());
        // Console.WriteLine(s2.GetArea());

        Circle s3 = new Circle("Red", 6);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

        
            double area= s. GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }

    }
}