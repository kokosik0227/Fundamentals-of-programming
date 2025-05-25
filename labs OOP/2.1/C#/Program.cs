using System;

class Program
{
    static void Main()
    {
        Segment segment1 = new Segment();
        Segment segment2 = new Segment(0, 0, 5, 6);

        Console.WriteLine($"Length of segment = {segment2.CalculateLength()}, Length of segment changed by 5 = {segment2.ChangedLength()}");
    }
}

