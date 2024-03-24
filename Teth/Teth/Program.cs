using System;

public class Tetrahedron
{
    private double[] vertex1;
    private double[] vertex2;
    private double[] vertex3;
    private double[] vertex4;

    public Tetrahedron(double[] v1, double[] v2, double[] v3, double[] v4)
    {
        vertex1 = v1;
        vertex2 = v2;
        vertex3 = v3;
        vertex4 = v4;
    }

    public double CalculateVolume()
    {
        double[] a = vertex1;
        double[] b = vertex2;
        double[] c = vertex3;
        double[] d = vertex4;

        double[] ab = VectorSubtract(b, a);
        double[] ac = VectorSubtract(c, a);
        double[] ad = VectorSubtract(d, a);

        double[] crossProduct = CrossProduct(ac, ad);

        double volume = Math.Abs(DotProduct(ab, crossProduct)) / 6.0;
        return volume;
    }

    private double[] CrossProduct(double[] v1, double[] v2)
    {
        double[] result = new double[3];
        result[0] = v1[1] * v2[2] - v1[2] * v2[1];
        result[1] = v1[2] * v2[0] - v1[0] * v2[2];
        result[2] = v1[0] * v2[1] - v1[1] * v2[0];
        return result;
    }

    private double DotProduct(double[] v1, double[] v2)
    {
        double result = 0;
        for (int i = 0; i < v1.Length; i++)
        {
            result += v1[i] * v2[i];
        }
        return result;
    }

    private double[] VectorSubtract(double[] v1, double[] v2)
    {
        double[] result = new double[v1.Length];
        for (int i = 0; i < v1.Length; i++)
        {
            result[i] = v1[i] - v2[i];
        }
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        double[] v1 = ReadVertexCoordinates("1");
        double[] v2 = ReadVertexCoordinates("2");
        double[] v3 = ReadVertexCoordinates("3");
        double[] v4 = ReadVertexCoordinates("4");
        Tetrahedron tetrahedron = new Tetrahedron(v1, v2, v3, v4);
        double volume = tetrahedron.CalculateVolume();
        Console.WriteLine("Volume of the tetrahedron: " + volume);
    }
    static double[] ReadVertexCoordinates(string vertexName)
    {
        double[] coordinates = new double[3];
        Console.WriteLine($"Enter coordinates for vertex {vertexName}:");
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Coordinate {i + 1}: ");
            coordinates[i] = double.Parse(Console.ReadLine());
        }
        return coordinates;
    }
}
