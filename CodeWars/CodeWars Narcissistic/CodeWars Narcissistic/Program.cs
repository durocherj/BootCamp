
bool returnTrue = Narcissistic(153);

Console.WriteLine(returnTrue);






static bool Narcissistic(int value)
{
    var length = value.ToString().Length;
    var intList = value.ToString().Select(x => int.Parse(x.ToString())).ToList();

    var checkMe = intList.Sum(x => Math.Pow(x, length));

    if (checkMe == value)
        return true;
    else
        return false;
}