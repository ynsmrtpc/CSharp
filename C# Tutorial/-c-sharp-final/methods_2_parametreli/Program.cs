using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_2_parametreli
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                hesap_makinesi();
            }
        }

        static int toplama(int sayi1 , int sayi2)
        {
            return sayi1 + sayi2;
        }

        static int cikarma(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

        static int carpma(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        static double bolme(double sayi1, double sayi2)
        {
            return sayi1 / sayi2;
        }

        static double kalan_bulma(double sayi1, double sayi2)
        {
            return sayi1 % sayi2;
        }

        static void hesap_makinesi()
        {
            int secim;
            Console.Write("1.Toplama\n2.Çıkarma\n3.Çarpma\n4.Bölme\n5.Kalan Bulma\n***Seçim:");
            secim = Convert.ToInt32(Console.ReadLine());

            if (secim > 5)
            {
                Console.WriteLine("Hatalı tuşlama!");
            }
            else
            {
                Console.Write("2 sayi girin:");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                int sayi2 = Convert.ToInt32(Console.ReadLine());

                if (secim == 1)
                {
                    Console.WriteLine("toplam:" + toplama(sayi1, sayi2));
                }

                else if (secim == 2)
                {
                    Console.WriteLine("fark:" + cikarma(sayi1, sayi2));
                }

                else if (secim == 3)
                {
                    Console.WriteLine("carpim:" + carpma(sayi1, sayi2));
                }

                else if (secim == 4)
                {
                    Console.WriteLine("bolüm:" + bolme(sayi1, sayi2));
                }

                else if (secim == 5)
                {
                    Console.WriteLine("kalan:" + kalan_bulma(sayi1, sayi2));
                }
            }
        }
    }
}