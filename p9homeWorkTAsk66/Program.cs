/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

//*******1 ВВОД ДАННЫХ*********
Console.Clear();

int m = GetNumberFromUser($"Enter M: ", "Input Error!");
int n = GetNumberFromUser($"Enter N: ", "Input Error!");

//*******2 ВЫЧИСЛЕНИЕ**********
//*******3 ВЫВОД ДАННЫХ*********
if (m > n) Console.Write($"M = {m}; N = {n} -> {GetSum(n, m)}");
 else Console.Write($"M = {m}; N = {n} -> {GetSum(m, n)}");
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
//*******2 ВЫЧИСЛЕНИЕ**********
int GetSum(int numberM, int numberN) 
{
    //int sum = 0;
    if (numberM == numberN) return numberM;
     return numberM + GetSum(numberM + 1, numberN);
}