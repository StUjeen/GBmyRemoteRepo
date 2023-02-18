/*Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.*/

//создание массива
int m = GetUserData("Enter m: ", "Error!");
int n = GetUserData("Enter n: ", "Error!");
int minVal = GetUserData("Enter minValue: ", "Error!");
int maxVal = GetUserData("Enter maxValue: ", "Error!");
//логика
///Создать массив
int[] array = GetArray(m, n, minVal, maxVal);
///подсчитать количество элементов
string result = GetCountOfEntries(array);
//вывод результата на экран
PrintArray(result);

//1 Ввод данных
int GetUserData(string message, string errorMeassage)
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
//2 Логика
int[,] GetArray(int m, int n, int minValue, int maxValues)
{
    int[,] array = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rand.Next(minValue, maxValue);
        }
    }
    return array;
}

string[] GetEntriesCount(int[] array)
{
    string[] count = new string[];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
             
        }
    }
}


//3 Вывод данных