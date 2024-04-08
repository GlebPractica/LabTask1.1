using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Solution
    {
        private double x;

        public Solution(double x)
        {
            this.x = x;
        }

        public double GetResult()
        {
            double epsilon = 0.001;
            double term = x;
            double suma = term;
            int n = 1;

            while (Math.Abs(term) > epsilon)
            {
                n++;
                term = Math.Pow(-1,n - 1) * Math.Pow(x, n) / n;
                suma += term;
            }

            return suma;
        }

        public override string ToString()
        {
            return string.Format("для переменных X = {0}",x);
        }
    }
}
