Console.WriteLine(StringsSum("5", " "));





static string StringsSum(string s1, string s2)
{
    if (s1 == " ")
        s1 = "0";
    if (s2 == " ")
        s2 = "0";
    

    int intOne = Convert.ToInt32(s1);
    int intTwo = Convert.ToInt32(s2);

    int sum = intOne + intTwo;

    string stringSum = Convert.ToString(sum);

    return stringSum;
}