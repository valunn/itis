using System;
using static System.Math;
using static System.Console;

namespace Course
{
    class Program
    {
        static double F(double x)
        {
            return Cos(Sin(x));
        }

        static double IntegrateSimpson(double a,double b, int n)
        {
            double delta = (b - a) / n;
            n /= 2;
            double sum1 = 0;
            for (int i = 1; i < n; i++)
                sum1 += F(a + 2*i*delta);
            double sum2 = 0;
            for(int i=1; i<=n; i++)
                sum2+=F(a+(2*i-1)*delta);
            return delta/3*(F(a) + F(b) + 2*sum1 + 4*sum2);
        }

        static void Main()
        {
            WriteLine(IntegrateSimpson(1, 3, 1000000));
        }
    }
}
