
int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };

//Minimum value
Console.WriteLine(nums.Min());
//Maximum value
Console.WriteLine(nums.Max());
//Max value below 10000
Console.WriteLine(nums.Where(x => x<1000).Max());
//All values between 10 and 100
Console.WriteLine(string.Join(" ",nums.Where(x => x>10 && x<100).DefaultIfEmpty()));
//Values between 100000 and 999999
Console.WriteLine(string.Join(" ", nums.Where(x => x > 100000 && x < 999999).DefaultIfEmpty()));
//Count the even numbers
Console.WriteLine(nums.Where(x => x%2 == 0).Count());

