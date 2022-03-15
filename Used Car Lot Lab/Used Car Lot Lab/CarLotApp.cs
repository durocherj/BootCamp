using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UsedCarLotLab
{
    public class CarLotApp
    {
        public static void ListCars(List<Car> carList)
        {
            int i = 1;
            Console.WriteLine(); // add a line space
            foreach (Car car in carList)
            {

                Console.WriteLine($"{i} {car.ToString()}");
                i++;
            }
            Console.WriteLine(); // add a line space
        }
        public static Car AddCar(bool isNew)
        {

            Console.WriteLine("Car Adder: Enter the Make: ");
            string make = Console.ReadLine();
            Console.WriteLine("Car Adder: Enter the Model: ");
            string model = Console.ReadLine();
            Console.WriteLine("Car Adder: Enter the Year: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Car Adder: Enter the Price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            if (isNew)
                return new Car(make, model, year, price);
            else
            {
                Console.WriteLine("Car Adder: Enter the Mileage: ");
                double mileage = double.Parse(Console.ReadLine());
                return new UsedCar(make, model, year, price, mileage);

            }
        }

        public static List<Car> BuyCar(int whichCar, List<Car> carList)
        {
            Console.WriteLine($"{carList[whichCar - 1]} removed.\n");
            carList.Remove(carList[whichCar - 1]);
            Console.WriteLine(); // add a line space
            return carList;
        }

        public static int UserChoice(int numChoices)
        {
            bool parsedSuccessfully = false;
            int userToDo = 1;
            do
            {
                string userInput = Console.ReadLine();
                parsedSuccessfully = int.TryParse(userInput, out userToDo);
                if (!parsedSuccessfully || userToDo <= 0 || userToDo > numChoices)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Entry not valid.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            while (!parsedSuccessfully);
            return userToDo;
        }
    }
}