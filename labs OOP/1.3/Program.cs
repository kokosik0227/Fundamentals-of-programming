using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {

        Rhombus P1 = new Rhombus();
        Rhombus P2 = new Rhombus(1.0, 2.0, 4.0);
        Rhombus P3 = new Rhombus(2.0, 1.0, 5.0, 4.0);


        P3 = P3 * 2.0;

        P1 = Rhombus.Subtract(new List<Rhombus> { P3, P2 });


        double[] coordsP1 = P1.GetCoordinates();
        Console.WriteLine($"Rhombus ({coordsP1[0]}, {coordsP1[1]}), ({coordsP1[2]}, {coordsP1[3]}) coordinates: ({coordsP1[0]}, {coordsP1[1]}), ({coordsP1[2]}, {coordsP1[3]})");
        Console.WriteLine($"Rhombus ({coordsP1[0]}, {coordsP1[1]}), ({coordsP1[2]}, {coordsP1[3]}) area: {P1.CalculateArea():F2}");
        Console.WriteLine($"Rhombus ({coordsP1[0]}, {coordsP1[1]}), ({coordsP1[2]}, {coordsP1[3]}) perimeter: {P1.CalculatePerimeter():F2}");
        Console.WriteLine();

        double[] coordsP2 = P2.GetCoordinates();
        Console.WriteLine($"Rhombus ({coordsP2[0]}, {coordsP2[1]}), ({coordsP2[2]}, {coordsP2[3]}) coordinates: ({coordsP2[0]}, {coordsP2[1]}), ({coordsP2[2]}, {coordsP2[3]})");
        Console.WriteLine($"Rhombus ({coordsP2[0]}, {coordsP2[1]}), ({coordsP2[2]}, {coordsP2[3]}) area: {P2.CalculateArea():F2}");
        Console.WriteLine($"Rhombus ({coordsP2[0]}, {coordsP2[1]}), ({coordsP2[2]}, {coordsP2[3]}) perimeter: {P2.CalculatePerimeter():F2}");
        Console.WriteLine();

        double[] coordsP3 = P3.GetCoordinates();
        Console.WriteLine($"Rhombus ({coordsP3[0]}, {coordsP3[1]}), ({coordsP3[2]}, {coordsP3[3]}) coordinates: ({coordsP3[0]}, {coordsP3[1]}), ({coordsP3[2]}, {coordsP3[3]})");
        Console.WriteLine($"Rhombus ({coordsP3[0]}, {coordsP3[1]}), ({coordsP3[2]}, {coordsP3[3]}) area: {P3.CalculateArea():F2}");
        Console.WriteLine($"Rhombus ({coordsP3[0]}, {coordsP3[1]}), ({coordsP3[2]}, {coordsP3[3]}) perimeter: {P3.CalculatePerimeter():F2}");
    }
}