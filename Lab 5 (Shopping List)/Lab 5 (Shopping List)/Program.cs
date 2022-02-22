// Shopping List Lab El & Jay

var error = "I'm sorry, that's not a valid input";
var repeat = true;

Dictionary<string, decimal> menu = new Dictionary<string, decimal>()
{
    {"cake", 5.99m },
    {"peanut butter", 3 },
    {"jam", 2.98m },
    {"banana" , .16m },
    {"apple" , .20m },
    {"grape juice", 2.35m },
    {"bread", 2.89m },
    {"eggs", 2.19m },
    {"milk", 2 },
    {"vodka" , 19.99m },
    {"beer", 6.89m }
};

List<string> shoppingList = new List<string>();
List<decimal> shoppingPrice = new List<decimal>();

Console.WriteLine("Welcome to LJ's Groceries");

while (repeat)
{
    Console.WriteLine(
        $"\nItem                 Price"+
        $"\n=============================================="+
        $"\nCake                 ${menu["cake"]}" +
        $"\nPeanut Butter        ${menu["peanut butter"]}" +
        $"\nJam                  ${menu["jam"]}" +
        $"\nBanana               ${menu["banana"]}"+
        $"\nApple                ${menu["apple"]}" +
        $"\nGrape Juice          ${menu["grape juice"]}" +
        $"\nBread                ${menu["bread"]}" +
        $"\nEggs                 ${menu["eggs"]}" +
        $"\nMilk                 ${menu["milk"]}" +
        $"\nVodka                ${menu["vodka"]}" +
        $"\nBeer                 ${menu["beer"]}");

    

    Console.WriteLine("What item would you like to add to your cart?");
    var itemInput = Console.ReadLine().ToLower();

    bool isItThere = menu.ContainsKey(itemInput);

    if (isItThere)
    {
        Console.WriteLine($"{itemInput} has been added to your cart for ${menu[itemInput]}");
        shoppingList.Add(itemInput);
        shoppingPrice.Add(menu[itemInput]);
    }   
            
    else
        Console.WriteLine(error);

    Console.WriteLine("Would you like to add another item? (y/n)");
    var yn = Console.ReadLine().ToLower();
    
    if (yn == "n")
    {
        Console.WriteLine("Thank you for shopping with us!\nHere is what you're getting:");
                

        foreach (string item in shoppingList)
            Console.WriteLine($"{item} for ${menu[item]}");

        var total = shoppingPrice.Sum();

        Console.WriteLine($"Your total is ${total}.");
        Console.WriteLine("Have a nice day!!!");

        repeat = false;
    }    
}
