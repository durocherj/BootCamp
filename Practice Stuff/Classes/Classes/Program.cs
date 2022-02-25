using Classes1;

var newDog = new Dog();

newDog.Breed = "Pitbull";
newDog.Age = 56;
newDog.Name = "Simba";
newDog.Weight = 45.00;

var secondNewDog = new Dog();

secondNewDog.Breed = "Great Dane";
secondNewDog.Age = 7;
secondNewDog.Name = "Blue";
secondNewDog.Weight = 50;

var thirdNewDog = new Dog();

thirdNewDog.Breed = "Labrador Retriever";
thirdNewDog.Age = 2;
thirdNewDog.Name = "Fido";
thirdNewDog.Weight = 65;

List<Dog> dogList = new List<Dog>();

dogList.Add(newDog);
dogList.Add(secondNewDog);
dogList.Add(thirdNewDog);

Console.WriteLine("Give me the name of your dog and I'll see if it's in the list.");

var userInput = Console.ReadLine();

var dogToFind = dogList.Where(x => x.Name == userInput).FirstOrDefault();

if(dogToFind == null)
{
    Console.WriteLine("I'm sorry we don't have that dog");
}
else
{
    Console.WriteLine("Yup, we have that dog");
}

foreach (Dog dog in dogList)
{
    Console.WriteLine(dog.Name);
    Console.WriteLine(dog.Breed);
    Console.WriteLine(dog.Age);
    Console.WriteLine(dog.Weight);

}


