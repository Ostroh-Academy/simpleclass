namespace SimpleProject;

public class Cone
{
    private readonly Point3D _baseCenter;
    private readonly Point3D _vertex;
    private readonly double _radius;

    public Cone(Point3D baseCenter, Point3D vertex, double radius)
    {
        _baseCenter = baseCenter;
        _vertex = vertex;
        _radius = radius;
    }

    public double CalculateGeneratrix()
    {
        var height = _vertex.DistanceTo(_baseCenter);
        
        var generatrix = Math.Sqrt(height * height + _radius * _radius);

        return generatrix;
    }
}