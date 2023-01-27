//test input
int palindrome;

while (true)
{
    Console.WriteLine("Enter number: ");
    try
    {
        palindrome = Convert.ToInt32(Console.ReadLine());
        if (Math.Abs(palindrome) < 100000 && Math.Abs(palindrome) > 9999)
            break;
        Console.WriteLine("Enter five digit number:");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Input error! {exc.Message}");
    }
}

if (palindrome % 10 == palindrome / 10000 && (palindrome / 10) % 10 == (palindrome / 1000) % 10)
{
    Console.WriteLine($"{palindrome} -> yes");
}
else
{
    Console.WriteLine($"{palindrome} -> no");
}

// Console.WriteLine((palindrome / 1000) % 10);
// Console.WriteLine((palindrome / 10) % 10);
// Console.WriteLine(palindrome / 10000);
// Console.WriteLine(palindrome % 10);
