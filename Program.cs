using Lab_2_patern;
using System;


class Program
{
	static void Main(string[] arg)
	{
		Console.WriteLine("Введіть координати вершин чотирикутника (x1, y1), (x2, y2), (x3, y3), (x4, y4):");
		Quadranglecs[] vertices = new Quadranglecs[4];

		for (int i = 0; i < 4; i++)
		{
			Console.Write($"Введіть координати вершини {i + 1}:");
			string[] coordinates = Console.ReadLine().Split(' ');
			double x = double.Parse(coordinates[0]);
			double y = double.Parse(coordinates[1]);
			vertices[i] = new Quadranglecs(x, y);
		}

		double perimeter = Quadranglecs.Perimeter(vertices);
		Console.WriteLine($"Периметр чотирикутника: {perimeter}");
	}
}
