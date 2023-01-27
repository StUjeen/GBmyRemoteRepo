///////////////////////////////////////////////////////
//////// Произведение чисел от 1 до N /////////////////
///////////////////////////////////////////////////////
// Сначала описываем этапы выполнения программы
// три этапа:
// 1 ввод данных
// 2 вычисление
// 3 вывод данных
/////////ТЕЛО ПРОГРАММЫ//////////////
//*******1 ВВОД ДАННЫХ*********
Console.Clear();

int[] num = GetRandomNumbers();
//*******2 ВЫЧИСЛЕНИЕ**********
//int productNumbers = GetProductNumbers(num);
//*******3 ВЫВОД ДАННЫХ*********
Console.Write($"[");
for (int i = 0; i < num.Length; i++)
{
    if (i == num.Length - 1)
    {
        Console.Write($"{num[i]}");
    }
    else
    {
        Console.Write($"{num[i]}, ");
    }

}
Console.Write($"]");
///////////////МЕТОДЫ/////////////////
//*******1 ВВОД ДАННЫХ*********
int[] GetRandomNumbers()
{
    int[] arr = new int[8];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
    return arr;
}

//*******2 ВЫЧИСЛЕНИЕ**********
/*int GetProductNumbers(int number)
{
    int product = 1;
    for (int i = 1; i <= number; i++)
    {
        product *= i;
    }
    return product;

}
*/