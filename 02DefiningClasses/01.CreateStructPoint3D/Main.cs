using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CreateStructPoint3D
{
    class MainTest
    {
        static void Main(string[] args)
        {
            Point3d pointOne = new Point3d();

            pointOne.PointX = 0.5;
            pointOne.PointY = 0.5;
            pointOne.PointZ = 0.5;
            Console.WriteLine(pointOne);
            Console.WriteLine(Point3d.ZeroPosition);
            Point3d pointTwo = new Point3d(1.5, 1.5, 1.5);
            
            Console.WriteLine(pointTwo);
            Console.WriteLine("Distance between");
            Console.WriteLine(Distance.DistanceBetween(pointOne, pointTwo));

            Path path = new Path();
            path.Add(pointOne);
            path.Add(pointTwo);
            PathStorage.SavePath(path, @"../../Points3d.txt");
            path.Clear();
            Console.WriteLine();
            Console.WriteLine("Path is saved and then cleared");

            path = PathStorage.LoadPath(@"../../Points3d.txt");
            Console.WriteLine();
            Console.WriteLine("After reloading again from file");
            Console.WriteLine();
            foreach (var item in path.Paths)
            {
                Console.WriteLine(item);
            }
        }
    }
}