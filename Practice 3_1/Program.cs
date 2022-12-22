int quater;
Console.Write("Enter number of the quater: ");

quater = Convert.ToInt32(Console.ReadLine());
if (quater < 1 || quater > 4)
{
    Console.WriteLine("Unacceptable number. Try again:");
    return;
}
// logic
if (quater == 1)
{
    Console.WriteLine("x > 0, y > 0");
}
else if (quater == 2)
{
    Console.WriteLine("x < 0, y > 0");
}
else if (quater == 3)
{
    Console.WriteLine("x < 0, y < 0");
}
else if (quater == 4)
{
    Console.WriteLine("x > 0, y < 0");
}