using Linq_Lab_Pt_2;


var jimmy = new Student() { Name = "Jimmy", Age = 13 };
var hannah = new Student() { Name = "Hannah", Age = 21 };
var justin = new Student() { Name = "Justin", Age = 30 };
var sarah = new Student() { Name = "Sarah", Age = 53 };
var hannibal = new Student() { Name = "Hannibal", Age = 15 };
var phillip = new Student() { Name = "Phillip", Age = 16 };
var maria = new Student() { Name = "Maria", Age = 63 };
var abe = new Student() { Name = "Abe", Age = 33 };
var curtis = new Student() { Name = "Curtis", Age = 10 };


List<Student> studentList = new List<Student>()
{
    jimmy,
    hannah,
    justin,
    sarah,
    hannibal,
    phillip,
    maria,
    abe,
    curtis
};




//Find all students 21 and older
var age21AndOver = studentList.Where(x => x.Age > 21).ToList();
foreach(var student in age21AndOver)
{
    Console.Write(student.Name + ",");
}
//List<string> canDrink = new List<string>();
//for (int i = 0; i < studentList.Count; i++)
//{
//    if (studentList[i].Age >= 21)
//        canDrink.Add(studentList[i].Name);

//}
//Console.WriteLine("The following students are old enough to drink: " + String.Join(",", canDrink));

//Find oldest student
var oldest = studentList.Max(x => x.Age);
var oldestStudent = studentList.FirstOrDefault(x => x.Age == oldest);
Console.WriteLine($"\nThe oldest student is {oldestStudent.Name}");

//Find youngest student
var youngest = studentList.Min(x => x.Age);
var youngestStudent = studentList.First(x => x.Age == youngest);
Console.WriteLine($"The youngest student is {youngestStudent.Name}");

//I understand everything below this line does not use LINQ as much as it should, but I spent 6 hours on this and I ran out of time.
//Find oldest student under 25
string oldestUnder25Name = null;
int oldestUnder25Age = 0;
for(int i = 0;i < studentList.Count; ++i)
{
    int checkAge = studentList[i].Age;
    //checks if we are dealing with someone under 25
    if(checkAge  < 25)
    {
        if(studentList[i].Age > oldestUnder25Age)
        {
            oldestUnder25Age = studentList[i].Age;
            oldestUnder25Name = studentList[i].Name;
        }
    }
}
Console.WriteLine($"{oldestUnder25Name} is the oldest student under 25 years old.");

//find all students over 21 with even ages
List<string> over21Even = new List<string>();
for (int i = 0; i < studentList.Count; i++)
{
    if (studentList[i].Age >= 21 && studentList[i].Age%2 != 1)
        over21Even.Add(studentList[i].Name);
}
Console.WriteLine("The following students are over 21 and their age is an even number: " + String.Join(",", over21Even));


//find all teenage students (13 - 19 inclusive)
List<string> teenagers = new List<string>();
for (int i = 0; i < studentList.Count; i++)
{
    if (studentList[i].Age >= 13 && studentList[i].Age <= 19)
        teenagers.Add(studentList[i].Name);
}
Console.WriteLine("The following students are teenagers: " + String.Join(",", teenagers));

//Find all students whose name starts with a vowel
List<string> vowelNames = new List<string>();
char[] vowels = { 'A', 'E', 'I', 'O', 'U', 'Y' };
for (int i = 0; i < studentList.Count; ++i)
{
    char first = studentList[i].Name.FirstOrDefault();
    if (vowels.Contains(first))
        vowelNames.Add(studentList[i].Name);
}
Console.WriteLine($"The following students have names beginning with vowels: " + String.Join(",", vowelNames));