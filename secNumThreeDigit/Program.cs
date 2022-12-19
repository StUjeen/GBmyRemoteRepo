//enter and test input data 
int number;
while (true)
{
    Console.WriteLine("Enter three digit number:");
    number = Convert.ToInt32(Console.ReadLine() ?? "");
    if (number > 99 && number < 1000)
        break;
    Console.WriteLine("Wrong number entered:");
}
 int result =  (number / 10) % 10;
Console.WriteLine($"{number} -> {result}");