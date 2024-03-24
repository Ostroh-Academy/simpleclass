using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Vector3d
    {
        private double x;
        private double y;
        private double z;

        public Vector3d(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double CalculateLength()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }
    }
}
