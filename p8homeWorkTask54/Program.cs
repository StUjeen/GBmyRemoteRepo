/* 
Задача 54: Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

///////////////////////Создание массива///////////////////////
int[,] sourceArray = {{1,4,7,2},{5,9,2,3},{8,4,2,4}};
PrintArray(sourceArray);
///////////////////////Сортировака массива///////////////////////
int[,] sortArray = SortArray(sourceArray);
///////////////////////Вывод результата на экран///////////////////////
Console.WriteLine();
PrintArray(sortArray);

/////////////////////////1 Ввод данных///////////////////////
// заданы в условии
/////////////////////////2 Логика///////////////////////
int[,] SortArray(int[,] sourceArray)
{
    for (int i = 0; i < sourceArray.GetLength(0); i++)
    {
        for (int j = 0; j < sourceArray.GetLength(1); j++)
        {
            int maxPosition = j;
            for (int jSecond = j+1; jSecond < sourceArray.GetLength(1); jSecond++)
            {
            if (sourceArray[i,jSecond] > sourceArray[i,maxPosition]) 
                maxPosition = jSecond;
            }
            int temp = sourceArray[i,j];
            sourceArray[i,j] = sourceArray[i,maxPosition];
            sourceArray[i,maxPosition] = temp;
        }
    }
    return sourceArray;
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