/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

/////////ТЕЛО ПРОГРАММЫ//////////////
//*******1 ВВОД ДАННЫХ*********
Console.Clear();
double[] array = CreateArray();
//*******2 ВЫЧИСЛЕНИЕ**********
double difference = GetDifferenceMinMaxElements(array);

//*******3 ВЫВОД ДАННЫХ*********
PrintArray(array);
Console.Write($" -> {difference}");

///////////////МЕТОДЫ/////////////////
//*******1 ВВОД ДАННЫХ*********
double[] CreateArray()
{
    Random rnd = new Random();
    int l = rnd.Next(1, 10);
    double[] arr = new double[l];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble(), 2);
    }
    return arr;
}

//*******2 ВЫЧИСЛЕНИЕ*********
///*****Считаем разницу мижду минимальным и максимальным значениями массива****
double GetDifferenceMinMaxElements(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min >= array[i])
            min = array[i];
    }
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max <= array[i])
            max = array[i];
    }
    double diff = Math.Round(max-min, 2);
    return diff;
}
//*******3 ВЫВОД ДАННЫХ*********
//вывод массива на экран
void PrintArray(double[] array)
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
            Console.Write($"{array[i]}; ");
        }
    }
}