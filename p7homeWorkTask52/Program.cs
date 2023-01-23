/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
//Console.WriteLine($"[{String.Join(",", array)}]");
/////////ТЕЛО ПРОГРАММЫ//////////////
Console.Clear();
//*******1 ВВОД ДАННЫХ*********
int m = GetDataFromUser("Enter m:","Error!");
int n = GetDataFromUser("Enter n:","Error!");
int minVal = GetDataFromUser("Enter minimal Random value:","Error!");
int maxVal = GetDataFromUser("Enter maximal Random value:","Error!");
//*******2 ВЫЧИСЛЕНИЕ**********
int[,] array = GetArray(m, n, minVal, maxVal);
double[] results = GetAverageByColumn(array);
//minValue, maxValue
//*******3 ВЫВОД ДАННЫХ*********
PrintArray(array);
PrintDoubleArray(results);

///////////////МЕТОДЫ/////////////////
//*******1 ВВОД ДАННЫХ*********
int GetDataFromUser(string message, string errorMeassage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMeassage);

    }
}
//*******2 ВЫЧИСЛЕНИЕ**********
int[,] GetArray(int m, int n, int minValue, int maxValue)
//int minVal, int maxVal
{
    int[,] array = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rand.Next(minValue, maxValue);
        }
    }
    return array;
}

double[] GetAverageByColumn(int[,] array)
{
    double columnSum = 0;
    double[] avg = new double[array.GetLength(1)];
     for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            columnSum = columnSum + array[i,j];
        }

        avg[j] = columnSum/array.GetLength(1);
        columnSum = 0;
    }
    return avg;
        
}
//*********3 ВЫВОД ДАННЫХ*********
void PrintArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j]} |");
        }
        Console.WriteLine();
    }
}

void PrintDoubleArray(double[] array)
{
    Console.Write($"Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write($"{Math.Round(array[i], 2)} | ");
        }
        Console.WriteLine();
}
