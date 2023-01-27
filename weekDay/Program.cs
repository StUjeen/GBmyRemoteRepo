
int[] dayNumber = {1,2,3,4,5,6,7};
string[] dayName = {"Monday","Teusday","Wensday","Thursday","Friday","Saturday","Sunday"};
int nameLength = dayName.Length;


Console.WriteLine("Please enter a number from 1 to 7");
int enterNumber = Convert.ToInt32(Console.ReadLine());
    if (enterNumber > nameLength)
    {
        Console.WriteLine("There is no such a day, please chose from 1 to 7");
    }
    else if (enterNumber < 1) 
    {
        Console.WriteLine("There is no such a day, please chose from 1 to 7");
    }
    else 
    {
        for (int i = 0; i < nameLength; i++) 
        {
            if (enterNumber == dayNumber[i]) 
            {
                Console.WriteLine("The day is " + dayName[i]);
            }
        }   
    }


