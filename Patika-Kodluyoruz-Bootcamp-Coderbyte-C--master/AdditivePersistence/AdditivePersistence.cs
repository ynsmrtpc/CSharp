/*
    Have the function AdditivePersistence(num) take the num parameter being 
    passed which will always be a positive integer and return its additive persistence
    which is the number of times you must add the digits in num until you reach a single digit. 
    For example: if num is 2718 then your program should return 2 
    because 2 + 7 + 1 + 8 = 18 and 1 + 8 = 9 and you stop at 9.

    // Tests //
    INPUT: 2718 - OUTPUT: 2
    INPUT: 4 - OUTPUT: 0
    INPUT: 19 - OUTPUT: 2 
*/
using System;
using System.Collections.Generic;
using System.Linq;

class AdditivePersistenceClass
{
    public static int AdditivePersistence(int num)
    {
        int count = 0;
        string str = num.ToString();
        while (str.Length > 1)
        {
            List<int> arr = str.Select(s => int.Parse(s.ToString())).ToList();
            str = arr.Aggregate((a, b) => a + b).ToString();
            count++;
        }
        return count;
    }

    static void Main()
    {
        Console
            .WriteLine(AdditivePersistence(Convert
                .ToInt32(Console.ReadLine())));
    }
}
