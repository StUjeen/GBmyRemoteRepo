/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
*/
//Console.WriteLine($"[{String.Join(",", array)}]");
/////////ТЕЛО ПРОГРАММЫ//////////////
Console.Clear();
//*******1 ВВОД ДАННЫХ*********
Console.Write("Enter m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());
//*******2 ВЫЧИСЛЕНИЕ**********
double[,] array = GetArray(m, n);
int row = GetRowFromUser("Enter row number: ",$"Wrong number, enter number between 0 and {array.GetLength(0) - 1} ");
int col = GetColFromUser("Enter col number: ",$"Wrong number, enter number between 0 and {array.GetLength(0) - 1} ");
double value = GetValue(row, col, array);
//minValue, maxValue
//*******3 ВЫВОД ДАННЫХ*********
PrintArray(array);
Console.WriteLine();
Console.Write($"Element row {row} - col {col} is {value}");

///////////////МЕТОДЫ/////////////////
//*******1 ВВОД ДАННЫХ*********
int GetRowFromUser(string message, string errorMeassage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber < array.GetLength(0))
            return userNumber;
        Console.WriteLine(errorMeassage);

    }
}

int GetColFromUser(string message, string errorMeassage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber < array.GetLength(1))
            return userNumber;
        Console.WriteLine(errorMeassage);

    }
}

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

double GetValue(int row, int col, double[,] array)
{
    double value = array[row, col];
    return value;
}
//*********3 ВЫВОД ДАННЫХ*********
void PrintArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{Math.Round(array[i, j], 2)} | ");
        }
        Console.WriteLine();
        // Console.WriteLine("============");
    }
}
