using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSpring
{
    class Point
    {
        int x;
        int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        Point point = new Point(10, 20);
        internal int[] GetXYPair()
        {
            int[] arr = { x, y };
            return arr;
        }
        protected internal double Distance(int x, int y)
        {
            int firstpos = x - this.x;
            int secondpos = y - this.y;
            return Math.Sqrt(Math.Pow(firstpos, 2) + Math.Pow(secondpos, 2));
        }
        protected internal double Distance(Point point)
        {
            int firstpos = point.x - x;
            int secondpos = point.y - y;
            return Math.Sqrt(Math.Pow(firstpos, 2) + Math.Pow(secondpos, 2));
        }
        public static explicit operator double(Point point) => Math.Sqrt(Math.Pow(point.x, 2) + Math.Pow(point.y, 2));
    }
}
