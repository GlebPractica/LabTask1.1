using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Solution
    {
        private double x,y,z;

        public Solution(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double GetResult()
        {
            return ((1 + Math.Pow(Math.Sin(x + y), 2)) / (Math.Abs(x - (2 * y / (1 + Math.Pow(x, 2) * Math.Pow(y, 2)))))) * Math.Pow(x, Math.Abs(y)) + Math.Pow(Math.Cos(Math.Atan(1 / z)), 2);
        }

        public override string ToString()
        {
            return string.Format("для переменных x = {0}, y = {1}, z = {2}",x,y,z);
        }
    }
}
