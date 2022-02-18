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

Dictionary<string, string> dictionaryWords = new Dictionary<string, string>();

dictionaryWords.Add("Mango", "Salsa");
dictionaryWords.Add("Hot", "Potato");
dictionaryWords.Add("Big", "Chungus");

foreach(KeyValuePair<string, string> kvp in dictionaryWords)
{
    Console.WriteLine($"{kvp.Key} {kvp.Value}");
}




