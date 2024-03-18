using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace straight_line
{
    /*
 13.	Створити об’єкт класу „пряма  ”. Визначити за допомогою методу класу, чи належить одна із двох введених користувачем точок.
 */
    internal class Line
    {
        private double a, b, c;

        public Line(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public bool IsOnLine(double x, double y)
        {
            return a * x + b * y + c == 0;
        }
    }
}
