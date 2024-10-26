public abstract class Shape
{
    // Private color field
    private string _color;

    // Constructor to initialize the color
    protected Shape(string color)
    {
        _color = color;
    }

    // Getter for color
    public string GetColor()
    {
        return _color;
    }

    // Setter for color
    public void SetColor(string color)
    {
        _color = color;
    }

    // Abstract method to compute the area
    public abstract double GetArea();
}