/////////////////////////////////////////////////////////
//////// (A и B) и возводит число ///////////////////////
//////// A в натуральную степень B /////////////////////
///////////////////////////////////////////////////////

// Сначала описываем этапы выполнения программы
// три этапа:
// 1 ввод данных
// 2 вычисление
// 3 вывод данных
/////////ТЕЛО ПРОГРАММЫ//////////////
//*******1 ВВОД ДАННЫХ*********
Console.Clear();
int[] inputArray = new int[2];
for (int i = 0; i < 2; i++)
{
    int num = GetNumbersFromUser($"Enter number[{i+1}]: ", "Input Error!");
    inputArray[i] = num;
}
//*******2 ВЫЧИСЛЕНИЕ**********
int power = GetPowerNumbers(inputArray[0], inputArray[1]);
//*******3 ВЫВОД ДАННЫХ*********

Console.Write($"{inputArray[0]}, {inputArray[1]} -> {power}");

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
int GetPowerNumbers(int a, int b)
{
    int result = Convert.ToInt32(Math.Pow(a, b));
    return result;
}