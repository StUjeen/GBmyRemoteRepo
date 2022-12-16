Console.WriteLine("Enter any number");
int x = Convert.ToInt32(Console.ReadLine() ?? "");
int result = (int)Math.Pow(x, 2);
Console.WriteLine($"{x} -> {result}");
