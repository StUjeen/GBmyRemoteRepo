/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
//Console.WriteLine($"[{String.Join(",", array)}]");
/////////ТЕЛО ПРОГРАММЫ//////////////
Console.Clear();
//*******1 ВВОД ДАННЫХ*********
Console.Write("Enter m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());

/*Console.WriteLine("Enter minimum value");
double minValue = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter maximum value");
double maxValue = Convert.ToDouble(Console.ReadLine());
*/
//*******2 ВЫЧИСЛЕНИЕ**********
double[,] array = GetArray(m, n);
//minValue, maxValue
//*******3 ВЫВОД ДАННЫХ*********
PrintArray(array);

///////////////МЕТОДЫ/////////////////
//*******1 ВВОД ДАННЫХ*********
//*******2 ВЫЧИСЛЕНИЕ**********
double[,] GetArray(int m, int n)
//double minVal, double maxVal
{
    double[,] array = new double[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rand.NextDouble();
        }
    }
    return array;
}

//*********3 ВЫВОД ДАННЫХ*********
void PrintArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{Math.Round(array[i,j],2)} | ");
        }
        Console.WriteLine();
       // Console.WriteLine("============");
    }    
}
