int[] weight = {1,8,3,2,6};
int i = 0;
int max = weight[0];

    while (i < 5)
    {
        if (weight[i] < max) 
        {
           i++;
        } else
        {
            max = weight[i];
            i++;
        }
    }

Console.WriteLine(max);
