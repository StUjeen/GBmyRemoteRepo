/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
//Console.WriteLine($"[{String.Join(",", array)}]");
/////////ТЕЛО ПРОГРАММЫ//////////////
//*******1 ВВОД ДАННЫХ*********
Console.Clear();

string[,] parameters = GetNumbersFromUser($"Enter parameters ", "Input Error!");
//*******2 ВЫЧИСЛЕНИЕ**********
double[] crossPoint = GetCrossPoint(parameters);
//*******3 ВЫВОД ДАННЫХ*********
PrintArray(crossPoint, parameters);

///////////////МЕТОДЫ/////////////////
//*******1 ВВОД ДАННЫХ*********
string[,] GetNumbersFromUser(string message, string errorMeassage)
{
    var inputArray = new string[2, 4] { { "b1", "k1", "b2", "k2" }, { "", "", "", "" } };
    for (int i = 0; i < 4; i++)
    {

        while (true)
        {
            Console.WriteLine($"{message} {inputArray[0, i]}");
            bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
            if (isCorrect)
                inputArray[1, i] = Convert.ToString(userNumber);
            break;
            Console.WriteLine(errorMeassage);
        }
    }
    return inputArray;
}


//*******2 ВЫЧИСЛЕНИЕ**********
double[] GetCrossPoint(string[,] parameters)
{
    //double[] paramArray = Convert.ToDouble(parameters[1,]);
    double b1 = Convert.ToDouble(parameters[1, 0]);
    double k1 = Convert.ToDouble(parameters[1, 1]);
    double b2 = Convert.ToDouble(parameters[1, 2]);
    double k2 = Convert.ToDouble(parameters[1, 3]);

    double x = -(b1 - b2) / (k1 - k2);
    double y = k2 * x + b2;
    double[] crossPoint = new double[2];
    crossPoint[0] = x;
    crossPoint[1] = y;
    return crossPoint;
}

//*********3 ВЫВОД ДАННЫХ*********
void PrintArray(double[] array, string[,] parameters)
{
    int len = parameters.Length / 2;

    for (int j = 0; j < len; j++)
        for (int i = 0; i < 2; i++)
        {
            if (i == 1 && j == len - 1)
            {
                Console.Write($"{parameters[i, j]} ");
            }
            else if (i == 1 && j < len - 1)
            {
                Console.Write($"{parameters[i, j]}, ");
            }
            else if (i == 0)
            {
                Console.Write($"{parameters[i, j]} = ");
            }
        }
    Console.Write($" -> ({array[0]}, {array[1]})");
}
