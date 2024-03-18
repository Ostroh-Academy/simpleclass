using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    public class ConvexQuadrilateralOnPlane
    {
        private int[] topA;
        private int[] topB;
        private int[] topC;
        private int[] topD; 

        public ConvexQuadrilateralOnPlane(int xTopA, int yTopA, int xTopB, int yTopB, int xTopC, int yTopC, int xTopD, int yTopD)
        {
            topA = new int[2];
            topB = new int[2];
            topC = new int[2];
            topD = new int[2];

            topA[0] = xTopA;
            topA[1] = yTopA;

            topB[0] = xTopB;
            topB[1] = yTopB;

            topC[0] = xTopC;
            topC[1] = yTopC;

            topD[0] = xTopD;
            topD[1] = yTopD;
        }
        
        public double Perimeter()
        {
            double side1 = CalculateSideLength(this.topA[0], this.topA[1], this.topB[0], this.topB[1]);
            double side2 = CalculateSideLength(this.topB[0], this.topB[1], this.topC[0], this.topC[1]);
            double side3 = CalculateSideLength(this.topC[0], this.topC[1], this.topD[0], this.topD[1]);
            double side4 = CalculateSideLength(this.topD[0], this.topD[1], this.topA[0], this.topA[1]);

            double perimeter = side1 + side2 + side3 + side4;

            return perimeter;
        }

        private double CalculateSideLength(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}

