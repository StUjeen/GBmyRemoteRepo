// create array method
void FillArray (int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index<length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

// print array method
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

//find in array method
int IndexOf(int[] collection, int find)
{
    int position = -1;
    for (int i=0; i < collection.Length; i++)
    {
        if (find == collection[i]) 
        {
            position = i;
            break;
        }
    }
    return position;
}


int [] array = new int [10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);