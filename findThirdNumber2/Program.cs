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
    Console.WriteLine($"{number} -> there is no third number");
//case 2 - 3 and more digits
else
{
    double log = Math.Log10(Math.Abs(number));
    int exponent = Convert.ToInt32(Math.Floor(log));
    int power = Convert.ToInt32(Math.Pow(10, exponent-2));
    int result = (number / power) % 10;
    Console.WriteLine($"{number} -> {result}");
}
