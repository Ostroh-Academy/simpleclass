using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class ArifmeticalProgression
    {
        public double a0 { get; set; }
        public double d { get; set; }
        public int n { get; set; }

        public ArifmeticalProgression(double a0, double d, int n)
        {
            this.a0 = a0;
            this.d = d;
            this.n = n;
        }

        public double SumOfProgression()
        {
          
            double sum = (double)(n * (2 * a0 + (n - 1) * d)) / 2;
            return sum;
        }
    }

   
}
