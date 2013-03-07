using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CreateStructPoint3D
{
    static class PathStorage
    {
        public static void SavePath(Path path, string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            {
                foreach (var points in path.Paths)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(points.PointX + "," + points.PointY + "," + points.PointZ);
                    writer.Write(sb);
                    writer.WriteLine();
                }
            }
        }

        public static Path LoadPath(string filePath)
        {
            Path tempPath = new Path();
            Point3d point = new Point3d();
            using (var reader = new StreamReader(filePath))
            {
                int i = 0;
                for (string line; (line = reader.ReadLine()) != null; i++)
                {
                    string[] points = line.Split(',');
                    point.PointX = double.Parse(points[0]);
                    point.PointY = double.Parse(points[1]);
                    point.PointZ = double.Parse(points[2]);
                    tempPath.Add(point);
                }
            }
            return tempPath;
        }
    }
}