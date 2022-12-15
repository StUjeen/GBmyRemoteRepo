int[] weight = {1,0,3,2,6,9};
int i = 0;
int max = weight[0];
int size = weight.Length;

    while (i < size)
    {
        if (weight[i] < max) 
        {
           i++;
        } else
        {
            max = weight[i];
            i++;
        }
        Console.WriteLine(max);
    }
Console.Write("Max is: ");
Console.WriteLine(max);
