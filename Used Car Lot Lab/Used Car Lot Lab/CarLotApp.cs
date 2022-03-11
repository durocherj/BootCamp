using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Used_Car_Lot_Lab
{
    public class CarLotApp
    {
        public static void ListCars(List<Car> carList)
        {
            int i = 1;
            foreach (Car car in carList)
            {
                Console.WriteLine($"{i}. {car.ToString()}");
                i++;
            }
        }

        public static Car AddCar(bool isNew)
        {
            Console.WriteLine("Please enter the make: ");
            string carMake = Console.ReadLine();
            Console.WriteLine("Please enter model: ");
            string carModel = Console.ReadLine();
            Console.WriteLine("Please enter the year: ");
            int carYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the price: ");
            decimal carPrice = decimal.Parse(Console.ReadLine());
            
            
            if (isNew)
                return new Car(carMake, carModel, carYear, carPrice);
            else
            {
                Console.WriteLine("Please enter the mileage: ");
                double carMileage = double.Parse(Console.ReadLine());
                return new UsedCar(carMake, carModel, carYear, carPrice, carMileage);

            }       

            
        }

        
    }
}
