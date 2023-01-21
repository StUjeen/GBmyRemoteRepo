/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
/////////ТЕЛО ПРОГРАММЫ//////////////
//*******1 ВВОД ДАННЫХ*********
Console.Clear();

int[] num = GetNumberFromUser($"Input Error!");
//*******2 ВЫЧИСЛЕНИЕ**********
int countPositive = GetCountPositiveNumbers(num);
//*******3 ВЫВОД ДАННЫХ*********
PrintArray(num);
Console.WriteLine($" -> {countPositive}");

///////////////МЕТОДЫ/////////////////
//*******1 ВВОД ДАННЫХ*********
int[] GetNumberFromUser(string errorMeassage)
{
    Random rand = new Random();
    int[] inputArray = new int[rand.Next(1, 10)];
    for (int i = 0; i < inputArray.Length; i++)
    {
        Console.Write($"Enter number {i} from {inputArray.Length}: ");
        string inputLine = Console.ReadLine();
        int inputNumber = Convert.ToInt32(inputLine);
        bool isCorrect = int.TryParse(inputLine, out int userNumber);
        if (isCorrect)
        {
            inputArray[i] = inputNumber;
            PrintArray(inputArray);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine(errorMeassage);
            i--;
        }
    }
    return inputArray;
}

//*******2 ВЫЧИСЛЕНИЕ**********
int GetCountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    return count;

}

//*********3 ВЫВОД ДАННЫХ*********
void PrintArray(int[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write($"{array[i]}]");
        }
        else
        {
            Console.Write($"{array[i]}; ");
        }
    }
}