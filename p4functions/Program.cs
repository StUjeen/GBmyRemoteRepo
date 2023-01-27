// Сначала описываем этапы выполнения программы
// три этапа:
// 1 ввод данных
// 2 вычисление
// 3 вывод данных
//*******1 ВВОД ДАННЫХ*********
Console.Clear();

int num = GetNumberFromUser("Enter integer A: ", "Input Error!");
//*******2 ВЫЧИСЛЕНИЕ**********
int sumNumbers = GetSumNumbers(num);
//*******3 ВЫВОД ДАННЫХ*********
Console.WriteLine($"{num} -> {sumNumbers}");

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
int GetSumNumbers(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number;
        number--;
    }
    return sum;
}