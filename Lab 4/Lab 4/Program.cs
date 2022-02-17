// See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome to the student database!");
string[] name = new string[] { "Michael", "Emily", "Melissa", "Richard" };
string[] hometown = new string[] { "Detroit", "Miami", "Los Angeles", "Toronto" };
string[] food = new string[] { "Pizza", "Tacos", "Cake", "Pasta" };
var repeat = true;
string error = "I'm sorry, that is not a valid entry";

while (repeat)
{
    Console.WriteLine("Please enter the number of the student you would like to learn about:" +
        "\n1. Michael" +
        "\n2. Emily " +
        "\n3. Melissa" +
        "\n4. Richard");

    var nameChoice = Console.ReadLine();
    int chosenName;
    bool validName = int.TryParse(nameChoice, out chosenName);

    if (validName && chosenName > 0 && chosenName < 5)
    {
        int nameIndex = chosenName - 1;
        Console.WriteLine($"Please choose which information you would like to learn about {name[nameIndex]}:" +
            "\n1. Hometown" +
            "\n2. Favorite Food");
        var infoChoice = Console.ReadLine();
        int chosenInfo;
        bool validInfo = int.TryParse(infoChoice, out chosenInfo);

        if (validInfo && chosenInfo > 0 && chosenInfo < 3)
        {
            if (chosenInfo == 1)
                Console.WriteLine($"{name[nameIndex]}'s hometown is {hometown[nameIndex]}");
            else
                Console.WriteLine($"{name[nameIndex]}'s favorite food is {food[nameIndex]}");
        }
        else
            Console.WriteLine(error);
    }
    else
        Console.WriteLine(error);

}

