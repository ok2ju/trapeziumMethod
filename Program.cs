using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integral
{
    class Program
    {
        public static double function(double x)
        {
            return Math.Pow(x, 4) + 2 * Math.Pow(x, 2) + 4;
        }

        public static double trapezium(double left, double right, double step)
        {
            double sum = 0;

            for (double i = left + step; i < right; i += step)
            {
                sum += function(i);
            }
            sum = (sum + 0.5 * (function(left) + function(right))) * step;

            return sum;
        }

        static void Main(string[] args)
        {
            double left = 0;
            double right = 10;
            double step = 0.01;

            double trap = trapezium(left, right, step);
            double divtrap = trapezium(left, right, step / 2);

            Console.WriteLine(divtrap);
            //S=h*((F(a)+F(b))/2 + sum(F(i)));
        }
    }
}
