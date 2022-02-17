// See https://aka.ms/new-console-template for more information


//string[] stringArray = new string[3] { "Banana", "Orange", "Grapefruit" };



//Console.WriteLine(Array.IndexOf(stringArray, "Orange"));

//Console.WriteLine(stringArray.Contains("Grapefruit"));


//int[] array = new int[4] {1,3,5,7};


//foreach(int i in array)
//{
//    Console.WriteLine(Array.IndexOf(array, 8));
//}

//using System.Collections;

//var arrayList = new ArrayList();

//arrayList.Add("monke");

//arrayList.Add(0);

//arrayList.Add("monke");

//for(int i = 0; i < arrayList.Count; i++)
//{
//    Console.Write($"{arrayList[i]} ");
//}

//List<int> intList = new List<int>();

//intList.Add(5);   

//intList.Add(33);

//intList.ForEach(x => Console.WriteLine(x));

//List<string> stringList = new List<string>()
//{
//    "FRIED",
//    "CHicKEN"
//};


//stringList.ForEach(x => Console.Write($"");

Console.WriteLine("Welcome to The List!");
List<string> shoppingList = new List<string>();
var repeat = true;

while(repeat)
{
    Console.WriteLine("What would you like to add to your list?");
    shoppingList.Add(Console.ReadLine().ToLower());
        
    shoppingList.ForEach(x => Console.WriteLine(x));


    Console.WriteLine("Would you like to add to the list? (y/n)");
    var addMore = Console.ReadLine().ToLower();

    if (addMore == "n")
        repeat = false;

}
