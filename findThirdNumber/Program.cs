///enter and test input data 
int number;
while (true)
{
    Console.WriteLine("Enter any number:");
    if (int.TryParse(Console.ReadLine(), out number))
        break;
    Console.WriteLine("Wrong number entered");
}
// case 1 less than 3 digits
if (number / 100 == 0) 
{
    Console.WriteLine($"{number} -> there is no third number");
}
//case 2 equal to exact 3 digits
else if (number / 100 > 0 && number / 100 < 10)
{
    int result = number % 10; 
    Console.WriteLine($"{number} -> {Math.Abs(result)}");
}
//case more than 3 digits
else
{   
    int index = -1;
    int initialNum = number;
    while (initialNum != 0)
    {
        initialNum = initialNum / 10;
        index ++;
    }
    int power = Convert.ToInt32(Math.Pow(10, index-2));
    int result = (number / power) % 10;
    Console.WriteLine($"{number} -> {Math.Abs(result)}");
}
