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
//logic - to find second digit
 int result =  (number / 10) % 10;

//show result
Console.WriteLine($"{number} -> {result}");