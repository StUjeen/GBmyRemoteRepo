Console.WriteLine("Enter any number");
int x = Convert.ToInt32(Console.ReadLine() ?? "");
int result = x * x;
Console.WriteLine($"{x} -> {result}");
