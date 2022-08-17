using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_asal_sayi
{
    class Program
    {
        static void Main(string[] args)
        {
            int kontrol, sayac=0;
            Console.Write("Sayı girin:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= sayi; i++)
            {
                kontrol = 0;
                for(int j = 2; j < i; j++)
                {
                    if(i%j == 0)
                    {
                        kontrol++;
                        break;
                    }
                }
                if(kontrol == 0)
                {
                    sayac++;
                    Console.Write(i + " - ");
                }
            }
            Console.WriteLine("\n{0} adet asal sayi bulundu", sayac);
            Console.ReadLine();
        }
    }
}
