namespace TrapezoidLibCS
{
    public struct Point
    {
        public double X { get; }
        public double Y { get; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    public class Trapezoid
    {
        private Point a, b, c, d;


        public Trapezoid()
        {
            a = new Point(0.0, 0.0);
            b = new Point(0.0, 0.0);
            c = new Point(0.0, 0.0);
            d = new Point(0.0, 0.0);
        }


        public Trapezoid(Point a, Point b, Point c, Point d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }


        public Trapezoid(Trapezoid other) : this(other.a, other.b, other.c, other.d)
        {

        }


        ~Trapezoid()
        {

        }


        public double CalculateArea()
        {
            return 0.5 * System.Math.Abs((a.X * b.Y + b.X * c.Y + c.X * d.Y + d.X * a.Y) -
                                      (b.X * a.Y + c.X * b.Y + d.X * c.Y + a.X * d.Y));
        }


        public double CalculatePerimeter()
        {
            return SideLength(a, b) + SideLength(b, c) + SideLength(c, d) + SideLength(d, a);
        }

        // Геттери
        public Point GetA() { return a; }
        public Point GetB() { return b; }
        public Point GetC() { return c; }
        public Point GetD() { return d; }


        private double SideLength(Point p1, Point p2)
        {
            return System.Math.Sqrt(System.Math.Pow(p2.X - p1.X, 2) + System.Math.Pow(p2.Y - p1.Y, 2));
        }
    }
}