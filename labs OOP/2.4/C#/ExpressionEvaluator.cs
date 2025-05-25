using System;

namespace ExpressionEvaluation
{
    public class ExpressionEvaluator
    {
        private double a;
        private double b;
        private double c;
        private double d;

        public ExpressionEvaluator()
        {
            a = 0.0;
            b = 1.0;
            c = 0.0;
            d = 0.0;
        }

        public ExpressionEvaluator(double a, double b, double c, double d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public double B
        {
            get { return b; }
            set
            {
                if (value == 0.0)
                {
                    throw new DivideByZeroException("Division by zero: b cannot be zero");
                }
                b = value;
            }
        }

        public double C
        {
            get { return c; }
            set { c = value; }
        }

        public double D
        {
            get { return d; }
            set { d = value; }
        }

        public double Evaluate()
        {
            double numerator = 1.0 + a - (b / 2.0);
            double innerSqrt = 24.0 + d - c;
            if (innerSqrt < 0.0)
            {
                throw new ArgumentException("Square root argument cannot be negative");
            }
            double denominator = Math.Sqrt(innerSqrt) + (a / b);
            if (denominator == 0.0)
            {
                throw new DivideByZeroException("Denominator cannot be zero");
            }
            return numerator / denominator;
        }

        public double Value
        {
            get { return Evaluate(); }
        }
    }
}