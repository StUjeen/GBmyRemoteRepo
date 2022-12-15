Console.WriteLine("Enter any number:");
    int number = Convert.ToInt32(Console.ReadLine() ?? "");

    string result = (number % 2 == 0) ? "Even" : "Odd"; 
    Console.WriteLine("The number " + number + " is " + result);
    
