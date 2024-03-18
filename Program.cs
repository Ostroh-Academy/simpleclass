using PatternsFirstLab;

var radius = 5;

var center = new Coordinates(0, 0, 0);

var sphere = new Sphere(radius, center);

var point = new Coordinates(1, 1, 1);

Console.WriteLine(sphere.IsPointInside(point) 
    ? "Point is inside of the sphere!" 
    : "Point is not inside of the sphere!");