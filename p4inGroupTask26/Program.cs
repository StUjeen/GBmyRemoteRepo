// Сначала описываем этапы выполнения программы
// три этапа:
// 1 ввод данных
// 2 вычисление
// 3 вывод данных
/////////ТЕЛО ПРОГРАММЫ//////////////
//*******1 ВВОД ДАННЫХ*********
Console.Clear();

int num = GetNumberFromUser("Enter integer A: ", "Input Error!");
//*******2 ВЫЧИСЛЕНИЕ**********
int countNumbers = GetCountNumbers(num);
//*******3 ВЫВОД ДАННЫХ*********
Console.WriteLine($"{num} -> {countNumbers}");


///////////////МЕТОДЫ/////////////////
//*******1 ВВОД ДАННЫХ*********
int GetNumberFromUser(string message, string errorMeassage)
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
int GetCountNumbers(int number)
{
    double log = Math.Log10(number);
    int count = Convert.ToInt32(Math.Ceiling(log));
    int rest = number % 10;
    //Console.WriteLine(rest);

    if (rest == 0 || number == 1)
    {
        return count = count + 1;
    }
    else
    {
        return count;
    }
}
