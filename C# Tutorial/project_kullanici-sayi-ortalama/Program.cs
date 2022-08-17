using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_kullanici_sayi_ortalama
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            Console.Write("Bir sayı girin:");
            int kullanici_sayi = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i<=kullanici_sayi; i++)
            {
              toplam += i;  
            }
            double ort = (double)toplam / kullanici_sayi;

            Console.WriteLine("toplam:" + toplam);
            Console.WriteLine("ortalama:" + ort);

                     if (ort > 50)
                      {
                          Console.WriteLine("Ortalama 50'den büyüktür.");
                      }
                      else if (ort < 50)
                      {
                          Console.WriteLine("Ortalama 50'den küçüktür.");
                      }
                      else if(ort == 50)
                      {
                          Console.WriteLine("Ortalama 50'ye eşittir.");
                      } 
            Console.ReadLine();
        }
    }
}
