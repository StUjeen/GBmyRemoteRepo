//input data
int[] array = {1,2,3,9,5,6,7,8,9,0};

Console.WriteLine("Enter the number to be found:");

int find = Convert.ToInt32(Console.ReadLine());

for (int i=0; i < array.Length; i++)
{
    if (find == array[i]) 
    {
        Console.WriteLine($"The number {find} has index {i} of the array");
        break;
    }
    else
    {
        Console.WriteLine($"NOT in index {i}");
    }
}

