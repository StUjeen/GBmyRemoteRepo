Console.WriteLine("Enter your name:");
string name = Console.ReadLine() ?? "";
if (name.ToLower() == "masha")
    {
    Console.Write("Hello, my dear ");
    Console.WriteLine(name);
    } 
else
    {
    Console.Write("Hi, ");
    Console.WriteLine(name);        
    }
