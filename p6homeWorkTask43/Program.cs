/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
//Console.WriteLine($"[{String.Join(",", array)}]");
/////////ТЕЛО ПРОГРАММЫ//////////////
//*******1 ВВОД ДАННЫХ*********
Console.Clear();

int k1 = GetNumbersFromUser($"Enter k1 (y = k1 * x + b1)", "Input Error!");
int b1 = GetNumbersFromUser($"Enter b1 (y = k1 * x + b1)", "Input Error!");
int k2 = GetNumbersFromUser($"Enter k2 (y = k2 * x + b2)", "Input Error!");
int b2 = GetNumbersFromUser($"Enter b2 (y = k2 * x + b2)", "Input Error!");

//*******2 ВЫЧИСЛЕНИЕ**********
double[] crossPoint = GetCrossPoint(k1, b1, k2, b2);
//*******3 ВЫВОД ДАННЫХ*********
PrintArray(crossPoint);

///////////////МЕТОДЫ/////////////////
//*******1 ВВОД ДАННЫХ*********
int GetNumbersFromUser(string message, string errorMeassage)
{
    while (true)
    {
        Console.WriteLine(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMeassage);
    }
}


//*******2 ВЫЧИСЛЕНИЕ**********
double[] GetCrossPoint(int k1, int b1, int k2, int b2)
{
    double x = -(b1 - b2) / (k1 - k2);
    double y = k2 * x + b2;
    double[] crossPoint = new double[2];
    crossPoint[0] = x;
    crossPoint[1] = y;
    return crossPoint;
}

//*********3 ВЫВОД ДАННЫХ*********
void PrintArray(double[] array)
{
    Console.Write($"k1={k1}, b1={b1}, k2={k2}, b2={b2} -> ({array[0]}, {array[1]})");
}