/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

//*******1 ВВОД ДАННЫХ*********
Console.Clear();

int numberM = GetNumberFromUser($"Enter M: ", "Input Error!");
int numberN = GetNumberFromUser($"Enter N: ", "Input Error!");

//*******2 ВЫЧИСЛЕНИЕ**********
//*******3 ВЫВОД ДАННЫХ*********
Console.Write($"M = {numberM}; N = {numberN} -> {GetAckerman(numberM, numberN)}");

///////////////МЕТОДЫ/////////////////
//*******1 ВВОД ДАННЫХ*********
int GetNumberFromUser(string message, string errorMeassage)
{
    while (true)
    {
        Console.Write($"{message}");
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return Convert.ToInt32(Math.Abs(userNumber));
        Console.WriteLine(errorMeassage);
    }
}
//*******2 ВЫЧИСЛЕНИЕ**********
int GetAckerman(int numberM, int numberN)
{
    //int sum = 0;
    //if (numberM == numberN) return numberM;
    //return numberM + GetSum(numberM + 1, numberN);


    ////
    if (numberM == 0)
    {
        return numberN + 1;
    }
    else if ((numberM > 0) && (numberN == 0))
    {
        return GetAckerman(numberM - 1, 1);
    }
    else if ((numberM > 0) && (numberN > 0))
    {
        return GetAckerman(numberM - 1, GetAckerman(numberM, numberN - 1));
    }
    else
    {
        return numberN + 1;
    }
}
