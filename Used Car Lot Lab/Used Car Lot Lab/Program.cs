
using Used_Car_Lot_Lab;

string error = "I'm sorry, that is not a valid option.";
bool repeat = true;

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

while (repeat)
{
    

    CarLotApp.ListCars(carList);

    Console.WriteLine("\n\nWould you like to:" +
        "\n1. Buy a car" +
        "\n2. Sell a car" +
        "\n3. Quit program");

    switch (int.Parse(Console.ReadLine()))
    {
        case 1:
            {
                CarLotApp.BuyCar();
                break;
            }

        case 2:
            {
                CarLotApp.AddCar();
                break;
            }

        case 3:
            {
                repeat = false;
                break;
            }

        default:
            {
                Console.WriteLine(error);
                break;
            }
            
        

    }
}