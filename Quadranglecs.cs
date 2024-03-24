using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_patern
{
	public class Quadranglecs
	{
		public double X { get; set; }
		public double Y { get; set; }

		public Quadranglecs(double x, double y)
		{
			X = x;
			Y = y;
		}

		public static double Length(Quadranglecs p1, Quadranglecs p2)
		{
			double dx = p2.X - p1.X;
			double dy = p2.Y - p1.Y;
			return Math.Sqrt(dx * dx + dy * dy);
		}

		public static double Perimeter(Quadranglecs[] vertices)
		{
			double perimeter = 0;
			int numVertices = vertices.Length;

			for (int i = 0; i < numVertices; i++)
			{
				perimeter += Length(vertices[i], vertices[(i + 1) % numVertices]);
			}

			return perimeter;
		}
	}
}
