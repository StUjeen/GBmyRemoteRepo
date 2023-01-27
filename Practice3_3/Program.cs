int x1;
int y1;
int x2;
int y2;

Console.Write("Enter X1: ");
x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter y1: ");
y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter X2: ");
x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter y2: ");
y2 = Convert.ToInt32(Console.ReadLine());

//logic

double distance = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));

Console.WriteLine($"A({x1},{y1}); B({x2},{y2}) -> {distance}");