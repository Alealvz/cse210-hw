using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold shapes
        List<Shape> shapes = new List<Shape>();

        // Create a Square instance and add to the list
        Square s1 = new Square("Red", 3);
        shapes.Add(s1);

        // Create a Rectangle instance and add to the list
        Rectangle s2 = new Rectangle("Blue", 4, 5);
        shapes.Add(s2);

        // Create a Circle instance and add to the list
        Circle s3 = new Circle("Green", 6);
        shapes.Add(s3);

        // Iterate through the list of shapes and display their color and area
        foreach (Shape s in shapes)
        {
            // Get the color of the shape
            string color = s.GetColor();

            // Get the area of the shape
            double area = s.GetArea();

            // Display the information
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}