/*
Have the function KnightJumps(str) read str which will be a string
consisting of the location of a knight on a standard 8x8 chess board
with no other places on the board. The structure of str will be the following: "(x,y)"
which represents the position of the knight with x and y ranging from 1 to 8. Your program
should determine the number of spaces the knight can move to from a given location. 
For example: if str is "(4 5)" then your program should output 8 because the knight can move
to 8 different spaces from position x=4 and y=5.

Examples: 
INPUT:"(1 1)" - OUTPUT: 2 
INPUT:"(2 8)" - OUTPUT: 3 
INPUT:"(4 5)" - OUTPUT: 8
*/
using System;
using System.Collections.Generic;

class KnightJumpsClass
{
    public static string KnightJumps(string str)
    {
        int posX = (int) Char.GetNumericValue(str[1]);
        int posY = (int) Char.GetNumericValue(str[3]);

        int result = 0;

        int[][] possiblePos = new int[8][];

        possiblePos[0] = new int[2] { 1, 2 };
        possiblePos[1] = new int[2] { 2, 1 };
        possiblePos[2] = new int[2] { 2, -1 };
        possiblePos[3] = new int[2] { 1, -2 };
        possiblePos[4] = new int[2] { -1, 2 };
        possiblePos[5] = new int[2] { -2, 1 };
        possiblePos[6] = new int[2] { -2, -1 };
        possiblePos[7] = new int[2] { -1, -2 };

        foreach (var item in possiblePos)
        {
            if (
                posX + item[0] > 0 &&
                posY + item[1] > 0 &&
                posX + item[0] < 9 &&
                posY + item[1] < 9
            )
            {
                result++;
            }
        }
        string resultStr = Convert.ToString(result);
        return resultStr;
    }

    static void Main()
    {
        // keep this function call here
        Console.WriteLine(KnightJumps(Console.ReadLine()));
    }
}
