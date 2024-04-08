using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Solution
    {
        private double a,b;

        public Solution(double x, double y)
        {
            this.a = x;
            this.b = y;
        }

        public double GetResult()
        {
            return Math.Atan(Math.Sin(a + Math.PI)/Math.Cos(b + 2.87))/ Math.Sqrt(a + Math.Pow(Math.Cos(b), 2));
        }

        public override string ToString()
        {
            return string.Format("для переменных A = {0}, B = {1}",a,b);
        }
    }
}
