namespace SimpleProject;

public class Point3D
{
    private readonly double _x;
    private readonly double _y;
    private readonly double _z;


    public Point3D(double x, double y, double z)
    {
        _x = x;
        _y = y;
        _z = z;
    }
    
    public double DistanceTo(Point3D otherPoint)
    {
        var dx = _x - otherPoint._x;
        var dy = _y - otherPoint._y;
        var dz = _z - otherPoint._z;
        
        return Math.Sqrt(dx * dx + dy * dy + dz * dz);
    }
}