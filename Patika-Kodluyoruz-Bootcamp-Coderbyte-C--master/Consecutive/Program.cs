/*
Have the function Consecutive(**arr**) take the array of integers 
stored in **arr** and return the minimum number of integers needed 
to make the contents of **arr** consecutive from the lowest number to 
the highest number. For example: If **arr** contains [4, 8, 6] then the 
output should be **2** because two numbers need to be added to the array 
(5 and 7) to make it a consecutive array of numbers from **4** to **8**.
Negative numbers may be entered as parameters and no array will have 
less than 2 elements.

### Examples
Input: new int[] {5,10,15}
Output: 8

Input: new int[] {-2,10,4}
Output: 10
*/
using System;

class MainClass
{
    public static int Consecutive(int[] arr)
    {
        int bigVal = arr[0];
        int lowVal = arr[0];
        int counter = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > bigVal)
            {
                bigVal = arr[i];
            }
            else if (arr[i] < lowVal)
            {
                lowVal = arr[i];
            }
        }

        for (int i = (lowVal + 1); i < bigVal; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] == i)
                {
                    counter -= 1;
                }
            }
            counter += 1;
        }

        return counter;
    }

    static void Main()
    {
        Console.WriteLine("Input: { 5, 10, 15 }");
        Console.WriteLine("Output: " + Consecutive(new int[] { 5, 10, 15 }));
        Console.WriteLine("Input: { -2, 10, 4 }");
        Console.WriteLine("Output: " + Consecutive(new int[] { -2, 10, 4 }));
        Console.WriteLine("Input: { -4, 15, 3, 2, 6 }");
        Console
            .WriteLine("Output: " + Consecutive(new int[] { -4, 15, 3, 2, 6 }));
        Console.WriteLine("Input: { 5, 5, 5 }");
        Console.WriteLine("Output: " + Consecutive(new int[] { 5, 5, 5 }));
    }
}
