Console.WriteLine("Введите первое число: ");
string input = Console.ReadLine() ?? "";

int number = int.Parse(input);

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine($"{number} -> да");
}
else
{
    Console.WriteLine($"{number} -> нет");
}
