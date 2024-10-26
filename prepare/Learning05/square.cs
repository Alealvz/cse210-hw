public class Square : Shape
{
    // Private side field
    private double _side;

    // Constructor to initialize the color and side
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // Override method to compute the area
    public override double GetArea()
    {
        return _side * _side;
    }
}