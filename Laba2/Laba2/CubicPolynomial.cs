using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2;

internal class CubicPolynomial
{
    private double _a0;
    private double _a1;
    private double _a2;
    private double _a3;

    public CubicPolynomial(double a3, double a2, double a1, double a0)
    {
        _a3 = a3;
        _a2 = a2;
        _a1 = a1;
        _a0 = a0;
    }

    public double Evaluate(double x)
    {
        return _a3 * Math.Pow(x, 3) + _a2 * Math.Pow(x, 2) + _a1 * x + _a0;
    }

    public double FindMinimum(double a, double b, double epsilon)
    {
        double minValue = double.MaxValue;
        double step = epsilon / 10;

        for (double x = a; x <= b; x += step)
        {
            double fx = Evaluate(x);
            if (fx < minValue)
            {
                minValue = fx;
            }
        }

        return minValue;
    }
}
