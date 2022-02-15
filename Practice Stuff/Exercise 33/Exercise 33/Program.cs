// See https://aka.ms/new-console-template for more information
var repeatLoop = true;
int[] intArray = new int[5] { 2, 8, 0, 24, 51 };
var error = "I'm sorry, that's not a valid entry.";
int indexValue;
while (repeatLoop)
{
    Console.WriteLine("Please input which index you'd like to view: ");
    var input = Console.ReadLine();
    bool inputValid = int.TryParse(input, out indexValue);

    if (inputValid)
    {
        if (indexValue >= 0 && indexValue <= intArray.Length)
        {
            Console.WriteLine($"The value at index {indexValue} is {intArray[indexValue]}. Would you like to change it (y/n)? ");
            var change = Console.ReadLine().ToLower();

            if (change == "y")
            {
                Console.WriteLine($"Please enter the new value of index {indexValue}: ");
                var newInput = Console.ReadLine();
                int newIndexValue;
                bool newInputValid = int.TryParse(newInput, out newIndexValue);
                if (newInputValid)
                    intArray[indexValue] = newIndexValue;
                    
                
                else
                    Console.WriteLine(error);

                
            }
            

            
        }
        else
            Console.WriteLine(error);
    }
    else
        Console.WriteLine(error);

    


    Console.WriteLine("Would you like to view another entry? (y/n)");

    var goAgain = Console.ReadLine().ToLower();

    if (goAgain == "y")
        continue;
    else
        Console.WriteLine("Thank you, have a nice day!");
    repeatLoop = false;

}
