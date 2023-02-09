/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


///////////////////////Создание массива///////////////////////
int[,] firstArray = { { 2, 4 }, { 3, 2 } };
int[,] secondArray = { { 3, 4 }, { 3, 3 } };
PrintArray(firstArray);
Console.WriteLine();
PrintArray(secondArray);
Console.WriteLine();

///////////////////////Произведение///////////////////////
int[,] productArray = Multiplication(firstArray, secondArray);

///////////////////////Вывод результата на экран///////////////////////
PrintArray(productArray);

/////////////////////////1 Ввод данных///////////////////////
// заданы в условии
/////////////////////////2 Логика///////////////////////
int[,] Multiplication(int[,] array1, int[,] array2)
{
    if (array1.GetLength(1) != array2.GetLength(0)) Console.WriteLine("Number of cols in first array dose not match number of rows in the second one");
    int[,] product = new int[array1.GetLength(0),array2.GetLength(1)];
    for (int j = 0; j < product.GetLength(1); j++)
    {
        for (int i = 0; i < product.GetLength(0); i++)
        {
            int elemetnValue = 0;
            for (int r = 0; r < array1.GetLength(1); r++)
            {
                elemetnValue = elemetnValue + array1[i,r]*array2[r,j];
            }
            product[i,j] = elemetnValue;
        }
    }

    return product;
}


/////////////////////////3 Вывод данных///////////////////////
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}