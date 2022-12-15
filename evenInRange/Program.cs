Console.WriteLine("Enter any positive number:");
    int N = Math.Abs(Convert.ToInt32(Console.ReadLine() ?? ""));
    //string ifEven = (N % 2 == 0) ? "Even" : "Odd";
    for (int i = 1; i <= N; i++)
    {
        if (i % 2 == 0)
        {
        Console.Write(" " + i);
        }
    }


