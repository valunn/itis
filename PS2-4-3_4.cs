using System;
using static System.Math;
using static System.Console;

namespace Course
{
    class Program
    {
        static double F(double x)
        {
            return -Sin(Tan(x));
        }

        static double IntegrateCRect(double a,double b,int n)
        {
            if (b < a || n <= 0)
                throw new ArgumentException("Invalid arguments");

            double delta = (b - a) / n;
            double sum = 0;
            double prev = a;
            double cur;
            for (int i = 1; i <= n; i++)
            {
                cur = F(a + i * delta);
                sum += cur + prev;
                prev = cur;
            }
            return delta*sum/2;
        }

        static double IntegrateTrapezoidal(double a, double b, int n)
            => IntegrateCRect(a, b, n);

        static void Main()
        {
            WriteLine(IntegrateTrapezoidal(2, 3, 1000000));
        }
    }
}
