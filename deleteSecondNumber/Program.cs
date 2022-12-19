var randomNumber = new Random();
int number = randomNumber.Next(100, 1000);

int a1 = number / 100;
int a2 = number % 10;


Console.Write($"{number} -> {a1}{a2}");

