namespace PatternsFirstLab;

public sealed class Sphere(double radius, Coordinates center)
{
    public bool IsPointInside(Coordinates point)
    {
        var distance = Math.Sqrt(Math.Pow(point.XValue - center.XValue, 2) + 
                                 Math.Pow(point.YValue - center.YValue, 2) + 
                                 Math.Pow(point.ZValue - center.ZValue, 2));
        
        return distance <= radius;
    }
}