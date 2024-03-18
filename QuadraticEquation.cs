using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class QuadraticEquation
    {
        public float A { get; set; }
        public float B { get; set; }
        public float C { get; set; }
        public QuadraticEquation(float a, float b, float c)
        {
            A = a;
            B = b;
            C = c;
        }
        public QuadraticEquation() : this(0, 0, 0)
        { }
        public bool HasRoots()
        {
            float discriminant = B * B - 4 * A * C;
            return discriminant >= 0;
        }
    }
}
