// See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome to the student database!");
string[] name = new string[] { "Michael", "Emily", "Melissa", "Richard" };
string[] hometown = new string[] { "Detroit", "Miami", "Los Angeles", "Toronto" };
string[] favoriteFood = new string[] { "Pizza", "Tacos", "Cake", "Pasta" };
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

    if (validName && chosenName > 0 && chosenName <= name.Length)
    {
        int nameIndex = chosenName - 1;
        
        var repeatChoice = true;

        while (repeatChoice)
        {
            Console.WriteLine($"Please choose which information you would like to learn about {name[nameIndex]}:" +
            "\n Hometown" +
            "\n Favorite food");
            var chosenInfo = Console.ReadLine().ToLower();
            

            if (chosenInfo == "hometown")
            {
                Console.WriteLine($"{name[nameIndex]}'s hometown is {hometown[nameIndex]}");
                repeatChoice = false;
            }
            else if (chosenInfo == "favorite food" || chosenInfo == "food")
            {
                Console.WriteLine($"{name[nameIndex]}'s favorite food is {favoriteFood[nameIndex]}");
                repeatChoice = false;
            }
            else
                Console.WriteLine(error);
        }
    }
    else
        Console.WriteLine(error);

    Console.WriteLine("Would you like to learn about another student? (y/n)");
    var newInquiry = Console.ReadLine().ToLower();
    if (newInquiry == "n")
        repeat = false;

}

