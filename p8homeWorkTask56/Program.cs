/* 
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

///////////////////////Создание массива///////////////////////
int[,] sourceArray = {{1,4,7,2},{5,9,2,3},{8,4,2,4},{5,2,6,7}};
PrintArray(sourceArray);
Console.WriteLine();
///////////////////////Поиск минимальной суммы///////////////////////
int lowestAmount = countLineSum(sourceArray);
///////////////////////Вывод результата на экран///////////////////////
Console.WriteLine();
Console.WriteLine($"{lowestAmount} строка");

/////////////////////////1 Ввод данных///////////////////////
// заданы в условии
/////////////////////////2 Логика///////////////////////
int countLineSum(int[,] sourceArray)
{
    int[] stringNumber = new int[sourceArray.GetLength(0)];
    for (int i = 0; i < sourceArray.GetLength(0); i++)
    {
        int lineSum = 0;
        for (int j = 0; j < sourceArray.GetLength(1); j++)
        {
            lineSum = lineSum + sourceArray[i,j];
        }
        stringNumber[i] = lineSum;
        Console.Write($"{i+1}: {lineSum}");
        Console.WriteLine();
    }

    int lineNumber = 1;
    int minSum = stringNumber[0];
     for (int i = 0; i < stringNumber.Length; i++)
     {
        if (stringNumber[i] < minSum)
            lineNumber = i+1;
     }
    return lineNumber;
}

/////////////////////////3 Вывод данных///////////////////////
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} |");
        }
        Console.WriteLine();
    }
}