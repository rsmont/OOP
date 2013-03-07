using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CreateStructPoint3D
{
    class Path
    {
        private readonly IList<Point3d> list;

        public IList<Point3d> Paths
        {
            get
            {
                return list;
            }
        }
        
        public void Add(Point3d point)
        {
            list.Add(point);
        }

        public void Clear()
        {
            list.Clear();
        }

        public Path()
        {
            list = new List<Point3d>();
        }
    }
}