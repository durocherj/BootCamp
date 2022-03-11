using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Used_Car_Lot_Lab
{
    public class UsedCar : Car
    {
        public double CarMileage { get; set; }

        

        public UsedCar(string carMake, string carModel, int carYear, decimal carPrice, double carMileage) 
            : base (carMake, carModel, carYear, carPrice)
        {
            this.CarMileage = carMileage;
        }

        public override string ToString()
        {
            return $"{this.CarYear} {this.CarMake} {this.CarModel} with {this.CarMileage} miles on it for ${this.CarPrice}";
        }
    }
}
