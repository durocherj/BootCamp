using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_44__Point_Class_
{
    internal class Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int Distance()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        public Point CalculateMidpoint(Point p)
        {
            //formula is x2 + x1/2, y2 + y1/2
            int xMidpoint = (p.x + this.x) / 2;
            int yMidpoint = (p.y + this.y) / 2;

            return new Point(xMidpoint, yMidpoint);


        }
    }

}