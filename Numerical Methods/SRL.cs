using System;

namespace SRL
{
    class Program
    {
        static double g(double x)
        {
            return 1.0 / 3 * Math.Cos(x);
        }

        static void IterativeMethod()
        {
            double eps = Math.Pow(10, -7);
            double x0 = 0, x1 = 0;
            int counter = 0;
            do
            {
                x1 = x0;
                x0 = g(x0);
                counter++;
            } while (Math.Abs(x1 - x0) > eps);

            Console.WriteLine("#### Iterative Method ####");
            Console.WriteLine("Counter: " + counter + " | X = " + x0);
        }

        static void NewtonsMethod()
        {
            double eps = Math.Pow(10, -7);
            double x0 = 0, x1 = 0;
            int counter = 0;
            do
            {
                x1 = x0;
                x0 = x1 - (f(x1) / fp(x1));
                counter++;
            } while (Math.Abs(x1 - x0) > eps);
            Console.WriteLine("#### Newton's Method ####");
            Console.WriteLine("Counter: " + counter + " | X = " + x0);
        }

        static double f(double x)
        {
            return (3 * x) + Math.Sin(x) - Math.Exp(x);
        }
        static double fp(double x)
        {
            return 3 + Math.Cos(x) - Math.Exp(x);
        }
        static void Main(string[] args)
        {
            IterativeMethod();
            NewtonsMethod();
        }
    }
}
