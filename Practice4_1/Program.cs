int n;

Console.Write("Enter N: ");
n = Convert.ToInt32(Console.ReadLine());


//logic
    Console.Write($"{n} -> ");
for (int i = 1; i <= n; i++)
{
    int sqrtI = Convert.ToInt32(Math.Pow(i, 2));
    Console.Write($"{sqrtI}, ");

}
