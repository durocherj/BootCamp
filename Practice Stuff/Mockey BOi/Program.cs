using System;

namespace Mockey_BOi
{
    class Program
    {
        static void Main(string[] args)
        {
          
        }
        public static bool IsTheSame(int a, int b)
        {
            bool same;
            if (a == b)
                same = true;
            else
                same = false;
            return same;            
        }
        public static double Subtract(double a, double b)
        {
            double diff = a - b;
            return diff;
        }
        public static string FindBuildingType(int a)
        {
            string output;
            if (4 <= a && a <= 10)
                output = "This is an office building!";
            else if (a >= 50)
                output = "This is a SUPER skyscraper!";
            else if (11 <= a && a <= 49)
                output = "This is a skyscraper!";
            else if (a <= 3 && a >0)
                output = "This is a house!";
            else if (a == 0)
                output = "That's a vacant lot!";
            else
                output = "That's a hole...";

            return output;
                
        }
    }
}
