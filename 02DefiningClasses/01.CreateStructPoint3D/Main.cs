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
            Point3d pointTwo = new Point3d();

            pointOne.PointX = 0.5;
            pointOne.PointY = 0.5;
            pointOne.PointZ = 0.5;
            Console.WriteLine(pointOne);

            pointTwo.PointX = 1.5;
            pointTwo.PointY = 1.5;
            pointTwo.PointZ = 1.5;
            Console.WriteLine(pointTwo);
            Console.WriteLine(Distance.DistanceBetween(pointOne, pointTwo));
            Path path = new Path();
            path.Add(pointOne);
            path.Add(pointTwo);

            PathStorage.SavePath(path, @"../../Points3d.txt");

            Path tempPath = PathStorage.LoadPath(@"../../Points3d.txt");

            Console.WriteLine();
            foreach (var item in tempPath.Paths)
            {
                Console.WriteLine(item);
            }
        }
    }
}
