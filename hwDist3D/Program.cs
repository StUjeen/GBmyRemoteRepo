// A point coordinates
int x1;
int y1;
int z1;

int x2;
int y2;
int z2;

Console.Write("Enter A(x): ");
x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter A(y): ");
y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter A(z): ");
z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter B(x): ");
x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter B(y): ");
y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter B(z): ");
z2 = Convert.ToInt32(Console.ReadLine());


//logic

double distance = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));

Console.WriteLine($"A({x1},{y1},{z1}); B({x2},{y2},{z2}) -> {distance}");