﻿Console.WriteLine("Enter first number:");
    int numFirst = Convert.ToInt32(Console.ReadLine() ?? "");
Console.WriteLine("Enter second number:");
    int numSecond = Convert.ToInt32(Console.ReadLine() ?? "");

string result = (numFirst == Math.Pow(numSecond, 2)) ? "YES": "NO";
Console.WriteLine("Is the first number a square of the second one? " + result);