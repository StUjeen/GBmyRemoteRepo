/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

/////////ТЕЛО ПРОГРАММЫ//////////////
//*******1 ВВОД ДАННЫХ*********
Console.Clear();
int[] array = CreateArray();
//*******2 ВЫЧИСЛЕНИЕ**********
int countEven = GetCountEvenInArray(array);

//*******3 ВЫВОД ДАННЫХ*********
Console.Write($"[");
for (int i = 0; i < array.Length; i++)
{
    if (i == array.Length - 1)
    {
        Console.Write($"{array[i]}]");
    }
    else
    {
        Console.Write($"{array[i]},");
    }
}
Console.Write($" -> {countEven}");

///////////////МЕТОДЫ/////////////////
//*******1 ВВОД ДАННЫХ*********
int[] CreateArray()
{
    Random rnd = new Random();
    int l = rnd.Next(1, 10);
    int[] arr = new int[l];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

//*******2 ВЫЧИСЛЕНИЕ*********
///*****Считаем количество четных элементов массива****
int GetCountEvenInArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }

    }
    return count;
}

