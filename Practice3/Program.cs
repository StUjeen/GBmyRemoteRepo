/*********************************************************
    Напишите программу, которая выводит третью цифру
    заданного числа или сообщает, что третьей цифры нет.
**********************************************************/
int num;

while(true)
{
    Console.Write("Введите целое число: ");

    try
    {
        num = Convert.ToInt32(Console.ReadLine());
        break;
    }
    catch(Exception exc)
    {
        Console.WriteLine($"Ошибка ввода! {exc.Message}");
    }
}


int num_abs = Math.Abs(num);

if (num_abs < 100)
{
    Console.WriteLine($"Третьей цифры нет");
    return;
}

int thirdNumberRight = num_abs / 100 % 10;

while(num_abs > 999)
{
    num_abs /= 10;
}
int thirdNumberLeft = num_abs % 10;


Console.WriteLine($"Третья цифра числа {num} справа -> {thirdNumberRight}");
Console.WriteLine($"Третья цифра числа {num} слева -> {thirdNumberLeft}");
