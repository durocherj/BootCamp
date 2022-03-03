using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_45__Square_Class_
{
    internal class Square
    {
        private int sideLength;

        public Square(int sideLength)
        {
            this.sideLength = sideLength;
        }

        public int CalculatePerimeter()
        {
            return this.sideLength * 4;

        }
        public int CalculateArea()
        {
            return this.sideLength * this.sideLength;
        }
    }
}
