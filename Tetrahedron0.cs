namespace Tetrahedron;

public class Tetrahedron0
{
    private double[][] _vertices;

    public Tetrahedron0(double[][] vertices)
    {
        if (vertices.Length != 4 || vertices[0].Length != 3)
            throw new ArgumentException("The tetrahedron must have 4 vertices with three coordinates each.");

        _vertices = vertices;
    }

    public double CalculateVolume()
    {
        double[] v0 = _vertices[0];
        double[] v1 = _vertices[1];
        double[] v2 = _vertices[2];
        double[] v3 = _vertices[3];

        return Math.Abs(
            (v3[0] - v0[0]) * ((v1[1] - v0[1]) * (v2[2] - v0[2]) - (v2[1] - v0[1]) * (v1[2] - v0[2])) +
            (v3[1] - v0[1]) * ((v1[2] - v0[2]) * (v2[0] - v0[0]) - (v2[2] - v0[2]) * (v1[0] - v0[0])) +
            (v3[2] - v0[2]) * ((v1[0] - v0[0]) * (v2[1] - v0[1]) - (v2[0] - v0[0]) * (v1[1] - v0[1]))) / 6;
    }
}