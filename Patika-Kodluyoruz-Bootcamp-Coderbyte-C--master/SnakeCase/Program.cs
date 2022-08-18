/*
Have the function SnakeCase(**str**) take the **str** parameter being 
passed and return it in proper snake case format where each word is 
lowercased and separated from adjacent words via an underscore. 
The string will only contain letters and some combination of delimiter 
punctuation characters separating each word.For example: if **str** is 
"BOB loves-coding" then your program should return the string 
**bob_loves_coding**.

### Examples
Input: "cats AND*Dogs-are Awesome"
Output: cats_and_dogs_are_awesome

Input: "a b c d-e-f%g"
Output: a_b_c_d_e_f_g
*/
using System;
using System.Linq;

class MainClass
{
    public static string SnakeCase(string str)
    {
        char[] delimiterChars = { '.', ',', '-', '%', '+', ' ', '*' };
        str = str.ToLower();
        string[] sol = str.Split(delimiterChars);
        string solStr =
            String.Join(" ", sol.Select(i => i.ToString()).ToArray());
        solStr = solStr.Replace(" ", "_");
        return solStr;
    }

    static void Main()
    {
        Console.WriteLine(SnakeCase(Console.ReadLine()));
    }
}
