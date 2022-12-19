Console.WriteLine("Введите первое число 1: ");
string input1 = Console.ReadLine() ?? "";
Console.WriteLine("Введите второе число 2: ");
string input2 = Console.ReadLine() ?? "";

int number1 = int.Parse(input1);
int number2 = int.Parse(input2);

if (number1 % number2 == 0)
{
    Console.WriteLine($"{number1}, {number2} -> кратно");
}
else if (number2 % number1 != 0)
{
    Console.WriteLine($"{number1}, {number2} -> не кратно, остаток {number2 % number1}");
}
