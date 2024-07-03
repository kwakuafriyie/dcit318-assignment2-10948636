using System;

namespace IMovableInterfaceProgram
{
    // Define the IMovable interface
    public interface IMovable
    {
        void Move();
    }

    // Create a Car class that implements IMovable
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Create a Bicycle class that implements IMovable
    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Car and Bicycle
            Car car = new Car();
            Bicycle bicycle = new Bicycle();

            // Call the Move() method on each instance
            Console.WriteLine("Calling Move() on Car:");
            car.Move();

            Console.WriteLine("\nCalling Move() on Bicycle:");
            bicycle.Move();

            // Demonstrate polymorphism using the interface
            Console.WriteLine("\nDemonstrating polymorphism:");
            IMovable[] movables = { car, bicycle };
            foreach (IMovable movable in movables)
            {
                movable.Move();
            }

            // Wait for user input before closing the console window
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}