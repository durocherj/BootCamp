using UsedCarLotLab;

bool repeat = true;
string error = "I'm sorry, that is not a valid option.";

List<Car> carList = new List<Car>();
var car1 = new Car("Ford", "Fusion", 2006, 20500.99m);
var car2 = new UsedCar("Lincoln", "Mercury", 1997, 5432.11m, 200000);
var car3 = new UsedCar("Volkswagen", "Passat", 2003, 5032.00m, 100350);
var car4 = new Car("Mini", "Cooper", 2021, 15000m);
var car5 = new UsedCar("Ford", "Focus", 2000, 12345.67m, 200);
var car6 = new Car("Chrysler", "Bus", 2022, 99988.80m);

carList.Add(car1);
carList.Add(car2);
carList.Add(car3);
carList.Add(car4);
carList.Add(car5);
carList.Add(car6);

string yn = "y";
while (yn == "y")
{
    bool isNew;
    Console.WriteLine("What would you like to do?\nChoose a number (1-5):" +
        "\n1. Show list.  2. Add car.  3. Select/Buy car.  4.Exit.");
    int userToDo = CarLotApp.UserChoice(4);

    switch (userToDo)
    {
        case 1:
            CarLotApp.ListCars(carList);
            break;
        case 2:
            Console.WriteLine("Add a car. Is it new? y or n");
            switch (Console.ReadLine().ToLower())
            {
                case "y":
                    isNew = true;
                    carList.Add(CarLotApp.AddCar(isNew));
                    break;
                case "n":
                    isNew = false;
                    carList.Add(CarLotApp.AddCar(isNew));
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(error +"\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }

            

            break;
        case 3:
            CarLotApp.ListCars(carList);
            int buyCar;
            var buyCarBool = int.TryParse(Console.ReadLine(), out buyCar);
            if (buyCarBool && buyCar <= carList.Count)
                carList = CarLotApp.BuyCar(buyCar, carList);
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(error + "\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
 

            break;
        case 4:
            yn = "n";
            break;
        default:

            break;
    }
}

