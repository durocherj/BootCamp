using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Used_Car_Lot_Lab
{
    public class Car
    {
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public int CarYear { get; set; }
        public decimal CarPrice { get; set; }

        public Car()
        {
            this.CarMake = "";
            this.CarModel = "POS";
            this.CarYear = 0;
            this.CarPrice = 0m;
        }
        public Car(string carMake, string carModel, int carYear, decimal carPrice)
        {
            this.CarMake = carMake;
            this.CarModel = carModel;
            this.CarYear = carYear;
            this.CarPrice = carPrice;
        }

        public override string ToString()
        {
            return $"{this.CarYear} {this.CarMake} {this.CarModel} for ${this.CarPrice}";
        }


    }
}
