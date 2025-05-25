using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Segment : Line
{
    public Segment() : base() { }
    public Segment(double x1, double y1, double x2, double y2) : base(x1, y1, x2, y2) { }

    public double ChangedLength()
    {
        return CalculateLength() - 5;
    }
}