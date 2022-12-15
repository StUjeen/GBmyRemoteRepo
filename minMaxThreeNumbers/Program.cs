Console.WriteLine("Enter first number:");
    int firstNumber = Convert.ToInt32(Console.ReadLine() ?? "");
Console.WriteLine("Enter second number:");
    int secondNumber = Convert.ToInt32(Console.ReadLine() ?? "");
Console.WriteLine("Enter third number:");
    int thirdNumber = Convert.ToInt32(Console.ReadLine() ?? "");
    int min = Math.Min(firstNumber, secondNumber);
        min = Math.Min(min, thirdNumber);
    int max = Math.Max(firstNumber, secondNumber);
        max = Math.Max(max, thirdNumber);
    Console.WriteLine("Min is: " + min + " and Max is: " + max);
    
