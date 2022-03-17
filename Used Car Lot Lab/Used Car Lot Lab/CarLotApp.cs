using System;
using System.Collections.Generic;
using System.Globalization;
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
            //Console.WriteLine("Car Adder: Enter the Year: ");
            int year;
            if(isNew)
                year = DateTime.Today.Year;
            else
            {
                Console.WriteLine("Car Adder: Enter the Year: ");
                bool yearParse = int.TryParse(Console.ReadLine(), out year);
                while (!yearParse || year < 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("I'm sorry, that's not a valid year. Please try again.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Car Adder: Enter the Year: ");
                    yearParse = int.TryParse(Console.ReadLine(), out year);
                }
                if(year < 100)
                {
                    year = CultureInfo.InvariantCulture.Calendar.ToFourDigitYear(year);
                }
            }
                
            Console.WriteLine("Car Adder: Enter the Price: ");
            decimal price;
            bool priceParse = decimal.TryParse(Console.ReadLine(), out price);
            //decimal price = decimal.Parse(Console.ReadLine());
            while (!priceParse || price < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;                
                Console.WriteLine("I'm sorry, that's not a valid price. Please try again.\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Car Adder: Enter the Price: ");
                priceParse = decimal.TryParse(Console.ReadLine(), out price);
            }

            if (isNew)
                return new Car(make, model, year, price);
            else
            {
                Console.WriteLine("Car Adder: Enter the Mileage: ");
                double mileage;
                bool mileageParse = double.TryParse(Console.ReadLine(), out mileage);
                while (!mileageParse || mileage < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("I'm sorry, that's not a valid mileage. Please try again.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Car Adder: Enter the Mileage: ");
                    mileageParse = double.TryParse(Console.ReadLine(), out mileage);
                }
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