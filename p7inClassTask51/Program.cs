////////ТЕЛО ПРОГРАММЫ//////////////
//*******1 ВВОД ДАННЫХ*********
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 10);

//*******2 ВЫЧИСЛЕНИЕ**********
int sum = GetSumArray(array);
//*******3 ВЫВОД ДАННЫХ*********
PrintArray(array);
Console.Write(sum);


///////////////МЕТОДЫ/////////////////
//*******1 ВВОД ДАННЫХ*********

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
//*******2 ВЫЧИСЛЕНИЕ**********

int GetSumArray(int[,] array)
{
    int resolutionMin = Math.Min(array.GetLength(0), array.GetLength(1));
    int sum = 0;
    for (int i = 0; i < resolutionMin; i++)
    {
        sum = sum + array[i,i];
    }
    return sum;
}
//*********3 ВЫВОД ДАННЫХ*********
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

