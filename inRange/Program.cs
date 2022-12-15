Console.WriteLine("Enter any number:");
    int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int[] rangeRow = new int[N*2+1];
rangeRow[0] = -N;
Console.Write(rangeRow[0]+" ");

    for (int i = 1; i < rangeRow.Length; i++ ) 
    {
        rangeRow[i] = rangeRow[i-1] + 1;
        Console.Write(rangeRow[i]+" ");
    }
