using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_asal_mi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            Console.Write("Sayı girin:");
            int sayi = int.Parse(Console.ReadLine());

            if(asal_mi(sayi))
                Console.WriteLine("***** Girdiğin sayı asal *****");
            else
                Console.WriteLine("! Girdiğin sayı asal değil !");

            Console.WriteLine("\n- Sonraki 5 asal sayı -\n");

            while (true)
            {
                sayi++;
                if (asal_mi(sayi))
                {
                    Console.WriteLine("- {0} sayısı asal", sayi);
                    sayac++;
                    if(sayac == 5)
                    {
                        break;
                    }
                } 
            }
            Console.Read();
        }
       static bool asal_mi(int sayi)
        {
            bool durum = false;
            int kontrol = 0;

            for (int i = 2; i < sayi; i++)
            {
                kontrol = 0;
                if (sayi % 2 == 0)
                {
                    kontrol++;
                    break;
                }
            }
            if (kontrol == 1)
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            return durum;
        }
    }
}
