/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
//Console.WriteLine($"[{String.Join(",", array)}]");
/////////ТЕЛО ПРОГРАММЫ//////////////
//*******1 ВВОД ДАННЫХ*********
Console.Clear();
//int row = GetNumbersFromUser($"Enter rows number:","Input Error!");
//int col = GetNumbersFromUser($"Enter columns number:","Input Error!");
//int max = GetNumbersFromUser($"Enter max value:","Input Error!");
//int min = GetNumbersFromUser($"Enter min value:","Input Error!");

//*******2 ВЫЧИСЛЕНИЕ**********
int rows = 3;
int cols = 4;
int[,] array = GetArray(rows, cols);
//*******3 ВЫВОД ДАННЫХ*********
PrintArray(array);
///////////////МЕТОДЫ/////////////////
//*******1 ВВОД ДАННЫХ*********
/*int GetNumbersFromUser(string message, string errorMeassage)
{
    while (true)
    {
        Console.WriteLine(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMeassage);
    }
}
*/
//*******2 ВЫЧИСЛЕНИЕ**********
int[,] GetArray(int m, int n)
{
    int[,] array = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = i+j;
        }
    }
    return array;
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
