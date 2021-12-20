using System;
using CoordinateSystem;

class Program
{
    static void Main()
    {
        Point3D a = new Point3D(1, 2, 3);
        Console.WriteLine("Point({0})", a); // point A

        Point3D b = Point3D.Center;
        Console.WriteLine("Point({0}, {1}, {2})", b.X, b.Y, b.Z); // point O
        
        Console.WriteLine("Distance: {0}", Distance.Calculate(a, b)); // Calculate distance

        // Path of points
        Path path = new Path(new Point3D(1, 1, 1), new Point3D(2, 2, 2));
        path.Add(new Point3D(3, 3, 3));
        path.Remove(new Point3D(1, 1, 1));
        Console.WriteLine("\nPoints in path (total: {0})\n{1}", path.Count, path);

        path.Clear();

        // Loads new points from the file
        path = PathStorage.Load("input.txt");
        Console.WriteLine("\nPoints in path (total: {0})\n{1}", path.Count, path);

        // Saves the points in output file
        PathStorage.Save(path, "output.txt");

        Console.ReadLine();
    }
}