using System;
using TrapezoidLibCS; // Підключаємо простір імен бібліотеки

namespace TrapezoidAppCS
{
    class Program
    {
        static void Main(string[] args)
        {

            Trapezoid t1 = new Trapezoid();
            Console.WriteLine("Trapezoid 1 (Default):");
            Console.WriteLine($"Area: {t1.CalculateArea()}, Perimeter: {t1.CalculatePerimeter()}");


            Point p1 = new Point(1, 1);
            Point p2 = new Point(4, 1);
            Point p3 = new Point(3, 3);
            Point p4 = new Point(2, 3);
            Trapezoid t2 = new Trapezoid(p1, p2, p3, p4);
            Console.WriteLine("\nTrapezoid 2 (Parameterized):");
            Console.WriteLine($"Area: {t2.CalculateArea()}, Perimeter: {t2.CalculatePerimeter()}");



            Trapezoid t3 = new Trapezoid(t2);
            Console.WriteLine("\nTrapezoid 3 (Copy of Trapezoid 2):");
            Console.WriteLine($"Area: {t3.CalculateArea()}, Perimeter: {t3.CalculatePerimeter()}");



        }
    }
}