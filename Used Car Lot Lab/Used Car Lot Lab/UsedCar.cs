using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarLotLab
{
    public class UsedCar : Car
    {
        public double Mileage;


        public UsedCar()
        {
            Make = "";
            Model = "";
            Year = 0;
            Price = 0M;
        }
        public UsedCar(string make, string model, int year, decimal price, double mileage)
            : base(make, model, year, price)
        {
            Mileage = mileage;
        }

        public override string ToString()
        {
            return $"{Make.PadRight(10)} {Model.PadRight(8)} {Year}  {Price.ToString("C")}" +
                $"" +
                $"" +
                $"  (Used) {Mileage.ToString()} miles";
        }
    }
}