Console.WriteLine("Enter three digit number:");
    string threeDigit = Console.ReadLine();
    int numberLength = threeDigit.Count();
while (numberLength != 3)
{
    Console.WriteLine("Enter three digit number:");
    threeDigit = Console.ReadLine();
    numberLength = threeDigit.Count();
    //Console.WriteLine(numberLength);
}

Console.WriteLine("The last didgit is: " + threeDigit.Substring(numberLength-1));