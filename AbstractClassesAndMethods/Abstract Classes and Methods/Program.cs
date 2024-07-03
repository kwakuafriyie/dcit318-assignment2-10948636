using System;

namespace AbstractShapeProgram
{
    // Abstract base class Shape
    public abstract class Shape
    {
        // Abstract method GetArea()
        public abstract double GetArea();
    }

    // Derived class Circle
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Implementation of GetArea() for Circle
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    // Derived class Rectangle
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        // Implementation of GetArea() for Rectangle
        public override double GetArea()
        {
            return width * height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Circle and Rectangle
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(4, 6);

            // Display areas
            Console.WriteLine($"Area of Circle with radius 5: {circle.GetArea():F2}");
            Console.WriteLine($"Area of Rectangle with width 4 and height 6: {rectangle.GetArea():F2}");

            // Wait for user input before closing the console window
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}