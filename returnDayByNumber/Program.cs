//initial data
int[] dayNumber = {1,2,3,4,5,6,7};
string[] dayName = {"Monday","Teusday","Wensday","Thursday","Friday","Saturday","Sunday"};
int nameLength = dayName.Length;

//input and test data
int enterNumber = 0;
while (true)
{
    Console.WriteLine("Please enter a number from 1 to 7:");
    if (int.TryParse(Console.ReadLine() ?? " ", out enterNumber))
    {
        if (enterNumber > nameLength || enterNumber < 1)
        {
            Console.WriteLine("There is no such a day, please choose from 1 to 7, next try");
        }
        else
            break;
    }  
    else
        Console.WriteLine("This is not a number at all, one more try");
}
//define if the number enterd falls to weekend or not
if (enterNumber > 5)
{
    Console.WriteLine($"{enterNumber} -> yes");
}
else
{
    Console.WriteLine($"{enterNumber} -> no");
}