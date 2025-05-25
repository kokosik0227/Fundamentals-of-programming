using System;
using System.Collections.Generic;

namespace ExpressionEvaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ExpressionEvaluator> evaluators = new List<ExpressionEvaluator>();
            evaluators.Capacity = 3;
            try
            {
                evaluators.Add(new ExpressionEvaluator(1.0, 2.0, 3.0, 4.0));
            }
            catch (Exception e)
            {
                Console.WriteLine("Construction error for object 1: " + e.Message);
            }

            try
            {
                evaluators.Add(new ExpressionEvaluator(5.0, 0.0, 6.0, 7.0));
            }
            catch (Exception e)
            {
                Console.WriteLine("Construction error for object 2: " + e.Message);
            }

            try
            {
                evaluators.Add(new ExpressionEvaluator(8.0, 4.0, 9.0, 10.0));
            }
            catch (Exception e)
            {
                Console.WriteLine("Construction error for object 3: " + e.Message);
            }

            List<double> results = new List<double>();
            results.Capacity = evaluators.Count;

            for (int i = 0; i < evaluators.Count; i++)
            {
                try
                {
                    double result = evaluators[i].Evaluate();
                    results.Add(result);
                    Console.WriteLine("Result for object " + i + ": " + result);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Divide by zero error for object " + i + ": " + e.Message);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("Argument error for object " + i + ": " + e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected error for object " + i + ": " + e.Message);
                }
            }

            Console.WriteLine("\nAll results: ");
            for (int i = 0; i < results.Count; i++)
            {
                Console.Write(results[i] + (i < results.Count - 1 ? ", " : "\n"));
            }
        }
    }
}