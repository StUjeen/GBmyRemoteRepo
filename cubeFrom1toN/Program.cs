int n;

Console.Write("Enter N: ");
n = Convert.ToInt32(Console.ReadLine());


//logic
Console.Write($"{n} -> ");
for (int i = 1; i <= n; i++)
{
    if (i < n)
    {
        int sqrtI = Convert.ToInt32(Math.Pow(i, 3));
        Console.Write($"{sqrtI}, ");
    }
    else
    {
        int sqrtI = Convert.ToInt32(Math.Pow(i, 3));
        Console.Write($"{sqrtI}.");
    }
}