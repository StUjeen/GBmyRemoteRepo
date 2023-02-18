/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

//*******1 ВВОД ДАННЫХ*********
Console.Clear();

int N = GetNumberFromUser($"Enter N: ", "Input Error!");
//*******2 ВЫЧИСЛЕНИЕ**********
Console.Write($"N = {N} -> '{GetSequence(N)}'");
//*******3 ВЫВОД ДАННЫХ*********
//PrintArray(crossPoint, parameters);

///////////////МЕТОДЫ/////////////////
//*******1 ВВОД ДАННЫХ*********
int GetNumberFromUser(string message, string errorMeassage)
{
    while (true)
        {
            Console.Write($"{message}");
            bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
            if (isCorrect)
                return userNumber;
            Console.WriteLine(errorMeassage);
        }   
}

string GetSequence(int number) 
{
    if (number == 1) return Convert.ToString(number);
     return number + ", " + GetSequence(number - 1);
}