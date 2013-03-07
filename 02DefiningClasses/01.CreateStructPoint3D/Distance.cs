using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CreateStructPoint3D
{
    static class Distance
    {
        public static double DistanceBetween(Point3d point1, Point3d point2)
        {
            double distance = Math.Sqrt(Math.Pow((point2.PointX - point1.PointX), 2) +
                                        Math.Pow((point2.PointY - point1.PointY), 2) +
                                        Math.Pow((point2.PointZ - point1.PointZ), 2));
            return distance;
        }
    }
}