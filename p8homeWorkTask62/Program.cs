/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

// 1 Задать массив
int m = 4;
int n = 4;
int[,] array = new int[m, n];
//int count = 0;
// 2 Заполнить массив 

FillArray(array);

// 3 Распечатать массив
PrintArray(array);

///////////Заполнить массив//////////////
int[,] FillArray(int[,] matrix)
{

    int m = matrix.GetLength(0);
    int n = matrix.GetLength(1);
    int i = 0;
    int j = 0;
    int counter = 0;
    while (counter < m * n)
    {
        matrix[i, j] = counter;
        counter++;

        if (i <= j + 1 && i + j < n - 1)
            j++;
        else if (i < j && i + j >= m - 1)
            i++;
        else if (i >= j && i + j > n - 1)
            j--;
        else
            i--;
    }
    return matrix;
}

///////////Распечатать массив//////////////
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}