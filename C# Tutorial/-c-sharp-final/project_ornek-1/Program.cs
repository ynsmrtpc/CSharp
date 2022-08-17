using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_ornek_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] sayi = new int[2];

            for (int i = 0; i < 2; i++)
            {
                Console.Write("{0}. sayıyı giriniz:", i + 1);
                sayi[i] = int.Parse(Console.ReadLine());
            }
            kontrol_et(sayi[0], sayi[1]);
            Console.ReadLine();
        }

        static void kontrol_et(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine("1. sayı 2. sayıdan büyüktür.");
            }
            else if (a == b)
            {
                Console.WriteLine("1. sayı 2. sayıya eşittir.");
            }
            else
            {
                Console.WriteLine("2. sayı 1. sayıdan büyüktür."); 
            }
        }
    }
}
