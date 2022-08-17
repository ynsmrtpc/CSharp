using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_diziler_falan
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[4];

            for(int i = 10; i<=sayilar.Length*10; i += 10)
            {
                for (int j = 0; j<sayilar.Length/4; j++)
                {
                    Console.Write((sayilar[j] = i) + " ");
                }              
            }
            string[] isimler = { "yunus", "emre", "topcu" }; // stringi bu şekilde kullanabiliriz.
            double[] ondalikli_sayilar = { 1.44, 7.66, 8.44, 10.5 };
            char[] character = { 'Y', 'U', 'N', 'U', 'S' };
           
            for (int j = 0; j < character.Length; j++)
            {
                Console.Write(character[j]);
            }
            Console.ReadLine();
        }
    }
}
