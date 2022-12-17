Console.WriteLine("Enter any positive number:");
    int N = Math.Abs(Convert.ToInt32(Console.ReadLine() ?? ""));
    Console.Write($"{N} -> ");

    for (int i = 1; i <= N; i++)
    {
        if (i % 2 == 0)
        {
        Console.Write($"{i} ");
        }
    }


