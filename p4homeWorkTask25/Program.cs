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
for (int i = 0; i < 8; i++)
{
int[] num = GetArrayFromUser($"Enter array element [{i}]: ","Input Error!");
}

//*******2 ВЫЧИСЛЕНИЕ**********
//int productNumbers = GetProductNumbers(num);
//*******3 ВЫВОД ДАННЫХ*********
Console.Write($"[");
Console.Write(num);
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