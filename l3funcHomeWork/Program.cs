// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int[] arr = { 1, 0, 6, 3, 9, 5, 7, 2, 8, 4 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        //                 i  j
        //int[] arr = { 9, 0, 1, 3, 6, 5, 7, 2, 8 };
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition])
            {
                maxPosition = j;
            }
        }
        int temp = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temp;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);