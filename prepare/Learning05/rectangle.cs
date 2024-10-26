public class Rectangle : Shape
{
    // Private length and width fields
    private double _length;
    private double _width;

    // Constructor to initialize the color, length, and width
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    // Override method to compute the area
    public override double GetArea()
    {
        return _length * _width;
    }
}