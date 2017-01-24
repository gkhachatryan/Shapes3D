# Shapes3D
This C# library will help you to calculate of volume, surface area and different types of movement of geometric shapes.
Class library **Shape3D** contains abstract class **AbstractShape**, which has 3 abstract members, **method Volume()** (which calculates volume of shape) and **method Area()** (which calculates area of shape). 
```C#
protected float a;
protected float b;
protected float c;
public abstract float Volume { get; }
public abstract float Area { get; }
```
**Shape3D** contains struct **Point3D** for determining x, y, z coordinates.
```C#
public struct Point3D
{
  public float X { get; set; }
  public float Y { get; set; }
  public float Z { get; set; }

  public Point3D(float x, float y, float z): this()
    {
      this.X = x;
      this.Y = y;
      this.Z = z;
    }
}
```
It has **IMuveable** interface , which provides shape's moving. It contains methods **MoveTo()**, **MoveBy()**

* Method MoveTo() allows you to move the shape to given location.
* Method MoveBy() allows you to move the shape by given difference coordinates dx, dy, dz.
```C#
public interface IMoveable
{
void MoveBy(float dx, float dy, float dz);
void MoveTo(float x, float y, float z);
void MoveTo(Point3D p);
}
```
# How to use
Classes **Ellipsoid** and **Parallelepiped** are inherited from **AbstractShape** abstract class and **IMuveable** interface.
For using this class library is necessary to add namespace Shape3D
```C#
Ellipsoid elips = new Ellipsoid(18, 21, 9);
Console.WriteLine("The volume of ellopsoid = {0} \nThe area of ellipsoid = {1}", elips.Volume, elips.Area);
Parallelepiped piped = new Parallelepiped(22, 13, 42);
Console.WriteLine("The volume of parallelepiped = {0}\nThe area of parallelepiped = {1}", piped.Volume, piped.Area);
```
# Result
![GitHub Logo](/Shape3D.png)
