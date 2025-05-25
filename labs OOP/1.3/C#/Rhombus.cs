using System;
using System.Collections.Generic;

public class Rhombus
{
    private double x1, y1, x2, y2;


    public Rhombus()
    {
        x1 = 0.0;
        y1 = 0.0;
        x2 = 1.0;
        y2 = 1.0;
    }

    public Rhombus(double x1, double y1, double x2, double y2 = 5)
    {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    }

    public Rhombus(Rhombus other)
    {
        x1 = other.x1;
        y1 = other.y1;
        x2 = other.x2;
        y2 = other.y2;
    }


    public double CalculateArea()
    {
        return Math.Abs((x2 - x1) * (y2 - y1));
    }

    public double CalculatePerimeter()
    {
        double side = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)) / Math.Sqrt(2);
        return 4 * side;
    }

    public double[] GetCoordinates()
    {
        return new double[] { x1, y1, x2, y2 };
    }


    public static Rhombus operator *(Rhombus r, double scalar)
    {
        double new_x1 = r.x1 * scalar;
        double new_y1 = r.y1 * scalar;
        double new_x2 = r.x2 * scalar;
        double new_y2 = r.y2 * scalar;

        if (scalar < 0)
        {
            return new Rhombus(new_x2, new_y2, new_x1, new_y1);
        }

        return new Rhombus(new_x1, new_y1, new_x2, new_y2);
    }
    public Rhombus Add(Rhombus other)
    {
        return new Rhombus(x1 + other.x1, y1 + other.y1, x2 + other.x2, y2 + other.y2);
    }


    public static Rhombus Subtract(List<Rhombus> rhombuses)
    {
        if (rhombuses.Count == 0)
        {
            throw new ArgumentException("List of rhombuses is empty");
        }

        Rhombus result = rhombuses[0];
        for (int i = 1; i < rhombuses.Count; i++)
        {
            result = new Rhombus(result.x1 - rhombuses[i].x1, result.y1 - rhombuses[i].y1,
                                 result.x2 - rhombuses[i].x2, result.y2 - rhombuses[i].y2);
        }
        return result;
    }

}