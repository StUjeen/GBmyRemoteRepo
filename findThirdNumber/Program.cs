//enter and test input data 
int number;
while (true)
{
    Console.WriteLine("Enter any number:");
    if (int.TryParse(Console.ReadLine(), out number))
        break;
    Console.WriteLine("Wrong number entered");
}
// logic
// define number of digits
int log = Convert.ToInt32(Math.Log10(number));


/*int index = -1;
int initialNum = number;
while (initialNum != 0)
{
    initialNum = initialNum / 10;
    index ++;
}
*/
// show
if (index < 2) 
{
    Console.WriteLine($"{number} -> there is no third number");
}
else 
{
    double power = Math.Pow(10, index);
    int result = Convert.ToInt32(number / power); 
    
    Console.WriteLine($"index of the number: {index}; power of the third right hand digit is {power}; third number from the right is: {result}");
}

Console.WriteLine(log);