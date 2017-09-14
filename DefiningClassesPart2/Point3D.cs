using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    public struct Point3D
    {
        public int X;
        public int Y;
        public int Z;

        private static readonly Point3D pointO = new Point3D(0, 0, 0);

        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Point3D PointO
        {
            get { return pointO; }
        }

        public override string ToString()
        {
            return "Width: " + X + "; Height: " + Y + "; Depth: " + Z;
        }
    }
}
