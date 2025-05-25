using System;

namespace StringPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers num = new Numbers("2007");
            Lowercase low = new Lowercase("nike");

            Strings str1 = num;
            Strings str2 = low;

            Console.WriteLine($"Initial value of num: {str1.GetValue()}");
            str1.Shift();
            Console.WriteLine($"After shift in num: {str1.GetValue()}");

            Console.WriteLine($"Initial value of low: {str2.GetValue()}");
            str2.Shift();
            Console.WriteLine($"After shift in low: {str2.GetValue()}");
        }
    }
}