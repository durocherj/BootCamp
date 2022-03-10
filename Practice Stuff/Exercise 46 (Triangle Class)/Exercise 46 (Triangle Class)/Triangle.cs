using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_46__Triangle_Class_
{
    public class Triangle
    {
        public double sideLengthA;
        public double sideLengthB;
        public double sideLengthC;

        public Triangle(double a, double b, double c)
        {
            sideLengthA = a;
            sideLengthB = b;
            sideLengthC = c;
        }

        public double GetPerimeter(Triangle triangle)
        {
            return triangle.sideLengthA + triangle.sideLengthB + triangle.sideLengthC;
        }

        public double GetArea()
        {
            double p = (sideLengthA + sideLengthB + sideLengthC) /2;

            return Math.Sqrt((p * (p - sideLengthA) * (p - sideLengthB) * (p - sideLengthC)));
        }
    }
}
