using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_kucuk_buyuk_bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 5, 60, 145, 95, 65, 3, 1, 0, 58 };
            Console.WriteLine("en buyuk:{0}" , max(numbers));
            Console.WriteLine("en kucuk:{0}", min(numbers));
            Console.ReadLine();
        }

        static int max(int[] sayilar)
        {        
            int buyuk = sayilar[0];

            for (int i = 0; i < sayilar.Length; i++)
            {
                if(buyuk < sayilar[i])
                {
                    buyuk = sayilar[i];
                }
            }
            return buyuk;
        }

        static int min(int[] sayilar)
        {
            int kucuk = sayilar[0];

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (kucuk > sayilar[i])
                {
                    kucuk = sayilar[i];
                }
            }
            return kucuk;
        }
    }
}
