using System;
using System.Linq;

namespace ConsoleApp2;

internal sealed class NumericSequence(double[] sequence)
{
    public double CalculateStandardDeviation()
    {
        if (sequence.Length < 2)
        {
            throw new InvalidOperationException("Sequence must contain at least two elements.");
        }

        var mean = CalculateMean();
        double sumOfSquares = 0;

        foreach (var num in sequence)
        {
            var deviation = num - mean;
            sumOfSquares += deviation * deviation;
        }

        var standardDeviation = Math.Sqrt(sumOfSquares / (sequence.Length - 1));
        return standardDeviation;
    }

    private double CalculateMean()
    {
        var sum = sequence.Sum();
        return sum / sequence.Length;
    }
}