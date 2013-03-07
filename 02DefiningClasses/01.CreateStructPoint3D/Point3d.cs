using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CreateStructPoint3D
{
    struct Point3d
    {
        private double pointX;

        public double PointX
        {
            get { return pointX; }
            set { pointX = value; }
        }


        public double PointY { get; set; }

        public double PointZ { get; set; }

        private static readonly Point3d zeroPosition = new Point3d(0,0,0);

        public static Point3d ZeroPosition
        {
            get
            {
                return  zeroPosition;
            }
        }

        public Point3d(double pointX, double pointY, double pointZ):this()
        {
            this.PointX = pointX;
            this.PointY = pointY;
            this.PointZ = pointZ;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("PointX: {0}", this.PointX.ToString());
            str.AppendLine();
            str.AppendFormat("PointY: {0}", this.PointY.ToString());
            str.AppendLine();
            str.AppendFormat("PointZ: {0}", this.PointZ.ToString());
            str.AppendLine();
            return str.ToString();
        }
    }
}