/*
Have the function PalindromeTwo(str) take the str parameter being 
passed and return the string true if the parameter is a palindrome, 
(the string is the same forward as it is backward) otherwise return the string false. 
The parameter entered may have punctuation and symbols but they should not affect 
whether the string is in fact a palindrome. 
For example: "Anne, I vote more cars race Rome-to-Vienna" should return true.


Examples: 
INPUT: "Noel - sees Leon" - OUTPUT: true
INPUT: "A war at Tarawa!" OUTPUT: true
INPUT: "Anne, I vote more cars race Rome-to-Vienna" OUTPUT: true

*/
using System;
using System.Text.RegularExpressions;

class PalindromeTwoClass
{
    public static string PalindromeTwo(string str = "")
    {
        str = str.Replace(" ", String.Empty);
        str = str.Replace("!", String.Empty);
        str = str.Replace(",", String.Empty);
        str = str.Replace(".", String.Empty);
        str = str.Replace("-", String.Empty);
        str = Regex.Replace(str, "[^a-zA-Z]", "").ToLower();
        string sol = "";

        for (int i = 0; i < str.Length; i++)
        {
            for (int j = str.Length - 1; j >= 0; j--)
            {
                if (str[i] == str[j])
                {
                    sol = "true";
                }
                else
                {
                    sol = "false";
                }
            }
        }
        return sol;
    }

    static void Main()
    {
        // keep this function call here
        Console.WriteLine(PalindromeTwo(Console.ReadLine()));
    }
}
