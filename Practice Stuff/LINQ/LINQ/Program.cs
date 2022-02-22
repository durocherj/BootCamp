

var intList = new List<int>()
{
    56,
    24,
    23,
    100,
    69,
    45,
    12,
    202
};

//Number of elements in a collection
Console.WriteLine(intList.Count());

//Number of odd numbers
Console.WriteLine(intList.Count(x => x % 2 == 1));

Console.WriteLine(string.Join(",", intList.Where(x => x > 50).ToList()));

var nameList = new List<string>()
{
    "Bob",
    "Nathaniel",
    "George",
    "Michael",
    "Stephanie",
    "Amy",
    "Joe Bob"
};

//Show me Amy if she's there
Console.WriteLine(string.Join(",", nameList.Where(x => x.Contains("o") && x.Contains("g")).ToList()));






