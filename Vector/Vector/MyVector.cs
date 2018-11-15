using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyVector
{
    public class Vector
    {
        public Vector(int x, int y)
        {
            this.x = (double) x;
            this.y = (double) y;
        }

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector() { }

        public double x { get; set; }
        public double y { get; set; }

        public double length()
        {
            return Math.Sqrt((x * x) + (y * y));
        }
    }
}
