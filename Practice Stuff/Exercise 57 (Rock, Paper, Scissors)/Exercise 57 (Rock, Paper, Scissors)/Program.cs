



using Exercise_57__Rock__Paper__Scissors_;

string error = "That is not a valid input, please start over.";
bool playAgain = true;

while (playAgain)
{
    Console.WriteLine("Player One, please choose rock(r), paper(p), or scissor(s): ");
    var playerOneInput = Console.ReadLine().ToUpper();
    RPS playerOneChoice;
    var playerOneInputValid = Enum.TryParse<RPS>(playerOneInput, out playerOneChoice);
    if (playerOneInputValid == false)
    {
        Console.WriteLine(error);
        continue;
    }

    Console.WriteLine("Player Two, please choose rock(r), paper(p), or scissors(s): ");
    var playerTwoInput = Console.ReadLine().ToUpper();
    RPS playerTwoChoice;
    var playerTwoInputValid = Enum.TryParse<RPS>(playerTwoInput, out playerTwoChoice);
    if (playerTwoInputValid == false)
    {
        Console.WriteLine(error);
        continue;
    }

    if (playerOneChoice == playerTwoChoice)
        Console.WriteLine("It's a draw");
    else if ((playerOneChoice == RPS.R && playerTwoChoice == RPS.S) || (playerOneChoice == RPS.P && playerTwoChoice == RPS.R) || (playerOneChoice == RPS.S && playerTwoChoice == RPS.P))
        Console.WriteLine("Player One wins!");
    else
        Console.WriteLine("Player Two wins");



        Console.WriteLine("Would you like to play again? (Y/N) ");
    var again = Console.ReadLine().ToLower();
    if (again == "n")
        break;
}