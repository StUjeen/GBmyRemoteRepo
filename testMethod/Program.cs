// Method to find maximum value among series of numbers
//input data
int a1 = 100;
int b1 = 1000;
int c1 = 10000;

int a2 = 200;
int b2 = 2000;
int c2 = 20000;

int a3 = 300;
int b3 = 3000;
int c3 = 30000;
//Method max from 3 args
int Max(int arg1, int arg2, int arg3) 
{
 int result = arg1;
 if (arg2>result) result=arg2;
 if (arg3>result) result=arg3;
 return result;
}

//use method max
int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
// find max from 3 maxs
int max = Max(max1, max2, max3);
// Output result
Console.Write(max);
