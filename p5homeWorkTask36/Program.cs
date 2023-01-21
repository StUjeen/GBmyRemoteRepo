/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

/////////ТЕЛО ПРОГРАММЫ//////////////
//*******1 ВВОД ДАННЫХ*********
Console.Clear();
int[] array = CreateArray();
//*******2 ВЫЧИСЛЕНИЕ**********
int sumOdd = GetSumOddElements(array);

//*******3 ВЫВОД ДАННЫХ*********
PrintArray(array);
Console.Write($" -> {sumOdd}");

///////////////МЕТОДЫ/////////////////
//*******1 ВВОД ДАННЫХ*********
int[] CreateArray()
{
    Random rnd = new Random();
    int l = rnd.Next(1, 10);
    int[] arr = new int[l];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 1000);
    }
    return arr;
}

//*******2 ВЫЧИСЛЕНИЕ*********
///*****Считаем количество четных элементов массива****
int GetSumOddElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}
//*******3 ВЫВОД ДАННЫХ*********
//вывод массива на экран
void PrintArray(int[] array)
{
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
}