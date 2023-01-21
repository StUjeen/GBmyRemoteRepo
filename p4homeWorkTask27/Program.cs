/* SЗадача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

/////////ТЕЛО ПРОГРАММЫ//////////////
//*******1 ВВОД ДАННЫХ*********
Console.Clear();
int num = GetNumbersFromUser($"Enter number: ", "Input Error!");
//*******2 ВЫЧИСЛЕНИЕ**********
int count = GetCountNumbers(num);
int sum = GetSumNumbers(num, count);
//*******3 ВЫВОД ДАННЫХ*********
Console.Write($"{num} -> {sum}");

///////////////МЕТОДЫ/////////////////
//*******1 ВВОД ДАННЫХ*********
int GetNumbersFromUser(string message, string errorMeassage)
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

//*******2 ВЫЧИСЛЕНИЕ*********
///*****Считаем еоличество цифр в числе****
int GetCountNumbers(int number)
{
    int i = 1;
    while((number / 10) > 0)
    {
        i++;
        number = number / 10;
    }
    return i;
}
///******Складываем цифры в числе******
int GetSumNumbers(int number, int length)
{
    int sum = 0;
    for (int i = 1; i <= length; i++)
    {
        sum = sum + (number % 10);
        number = number / 10;
    }
    return sum;
}