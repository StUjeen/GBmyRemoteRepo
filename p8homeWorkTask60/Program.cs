/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

// 0 Ввести размерность массива
int m = GetNumbersFromUser("Enter 'm' value: ","Input Error!");
int n = GetNumbersFromUser("Enter 'n' value: ","Input Error!");
int l = GetNumbersFromUser("Enter 'l' value: ","Input Error!");
// 1 Задать трехмерный массив
int[,,] array = GetArray(m, n, l);
// 2 Распечатать массив
PrintArray(array);

///////////Задать размеры массива//////////////
int GetNumbersFromUser(string message, string errorMeassage)
{

        while (true)
        {
            Console.WriteLine($"{message}");
            bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
            if (isCorrect)
                return userNumber;
            //break;
            Console.WriteLine(errorMeassage);
        }
}

///////////Сформировать массив//////////////
int[,,] GetArray(int m, int n, int l)
{
    Random rnd = new Random();
    int[,,] matrix = new int[m,n,l];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                matrix[i,j,k] = rnd.Next(10, 99);
            }
        }
    }
    return matrix;
}

///////////Распечатать массив//////////////
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
            Console.Write($"{array[i, j, l]}({i},{j},{l}) ");
            }
        Console.WriteLine();
        }
    }
}