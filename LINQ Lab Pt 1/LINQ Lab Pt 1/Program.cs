
int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };

Console.WriteLine(nums.Min());
Console.WriteLine(nums.Max());
Console.WriteLine(nums.Where(x => x<1000).Max());
Console.WriteLine(string.Join(" ",nums.Where(x => x>10 && x<100).DefaultIfEmpty()));
Console.WriteLine(string.Join(" ", nums.Where(x => x > 100000 && x < 999999).DefaultIfEmpty()));
Console.WriteLine(nums.Where(x => x%2 == 0).Count());

