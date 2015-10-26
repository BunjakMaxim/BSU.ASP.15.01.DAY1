using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1NewtanMetod
{
    public static class Task1NewtanMetod
    {
        public static double SqrtNewtanMetod(double value, int n, double precision = 0.00001)
        {
            double x, x1 = 1;
            if (value == 0) return 0;
            if (value < 0) throw new ArgumentException("Negative value!");

            do
            {
                x = x1;
                x1 = 1.0 / n * ((n - 1) * x + value / Math.Pow(x, n - 1));
            } while (Math.Abs(x - x1) > precision);

            return x;
        }
    }
}
