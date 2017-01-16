# Shapes3D
This C# library will help you to calculate of volume, surface area and different types of movement of geometric shapes.
Class library Shape3D contains abstract class AbstractShape, which has 3 abstract members; method Volume() (which calculates volume of shape) and method Area() (which calculates area of shape). 
```C#
protected float a;
protected float b;
protected float c;
public abstract float Volume { get; }
public abstract float Area { get; }
```
# How to use
```C#
Ellipsoid elips = new Ellipsoid(18, 21, 9);
Console.WriteLine("The volume of ellopsoid = {0} \nThe area of ellipsoid = {1}", elips.Volume, elips.Area);
Parallelepiped piped = new Parallelepiped(22, 13, 42);
Console.WriteLine("The volume of parallelepiped = {0}\nThe area of parallelepiped = {1}", piped.Volume, piped.Area);
```
