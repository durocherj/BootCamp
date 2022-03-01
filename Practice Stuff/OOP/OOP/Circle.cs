using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Circle
    {
        public double Radius { get; set; }
        private double _Circumference { get; set; }

        public Circle(double radius)
        {
            Radius = radius;

            _Circumference = 2 * Math.PI * radius;
        }

        public double GetCircumference()
        {
            return _Circumference;
        }
    }
}
