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
int[] inputArray = new int[8];
for (int i = 0; i < 8; i++)
{
    int num = GetArrayFromUser($"Enter array element [{i}]: ", "Input Error!");
    inputArray[i] = num;
}
//*******2 ВЫЧИСЛЕНИЕ**********
//*******3 ВЫВОД ДАННЫХ*********
for (int i = 0; i < inputArray.Length; i++)
{
    if (i == inputArray.Length - 1)
    {
        Console.Write($"{inputArray[i]} -> ");
    }
    else
    {
        Console.Write($"{inputArray[i]},");
    }

}
Console.Write($"[");
for (int i = 0; i < inputArray.Length; i++)
{
    if (i == inputArray.Length - 1)
    {
        Console.Write($"{inputArray[i]}");
    }
    else
    {
        Console.Write($"{inputArray[i]},");
    }

}
Console.Write($"]");
///////////////МЕТОДЫ/////////////////
//*******1 ВВОД ДАННЫХ*********

int GetArrayFromUser(string message, string errorMeassage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMeassage);

    }
}