Console.WriteLine("Enter first number:");
    int firstNumber = Convert.ToInt32(Console.ReadLine() ?? "");
Console.WriteLine("Enter second number:");
    int secondNumber = Convert.ToInt32(Console.ReadLine() ?? "");
    int min = Math.Min(firstNumber, secondNumber);
    int max = Math.Max(firstNumber, secondNumber);
    
    Console.WriteLine("Min is: " + min + " and Max is: " + max);
    
