using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizide_kullanicinin_deger_bulmasi
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1'DEN KULLANICININ BELİRLEDİĞİ SAYIYA KADAR OLAN ASAL SAYILARIN LİSTESİNİ BULAN VE BU LİSTEYİ EKRANA YAZDIRAN
            // DAHA SONRA KULLANICININ ARADIĞI DEĞERİN O LİSTEDE VAR OLUP OLMADIĞINI KONTROL EDEN VE KULLANICIYA GERİBİLDİRİM VEREN PROGRAM (DİZİ)

            /*            int kontrol, sayac = 0;
                        Console.Write("Sayı girin:");
                        int sayi = Convert.ToInt32(Console.ReadLine());
                        int[] asal_dizi = new int[sayi];
                        int temp;

                        for (int i = 2; i <= sayi; i++)
                        {
                            kontrol = 0;
                            for (int j = 2; j < i; j++)
                            {
                                if (i % j == 0)
                                {
                                    kontrol++;
                                    break;
                                }
                            }
                            if (kontrol == 0)
                            {
                                sayac++;
                                Console.Write(i + " - ");
                                temp = i;
                            }
                        }

                        for (int k = 0; k <= sayac; k++)
                        {
                            asal_dizi[k] = temp;
                        }
                        Console.WriteLine("\n**********************************");
                        foreach (int item in asal_dizi)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine("\n**********************************");

                        Console.WriteLine("\n{0} adet asal sayi bulundu", sayac);
                        Console.ReadLine();*/

            // KULLANICIYA GERİBİLDİRİM VERME ÖRNEK KOD

            int[] sayilar = { 10, 20, 20, 30, 30, 30, 40, 40, 40, 40, 50, 50, 50, 50, 50 };
            int adet = 0;
            int sayi;

            Console.Write("sayi gir:");
            sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < sayilar.Length; i++)
            {
                if(sayi == sayilar[i])
                {
                    adet++;
                }
            }
            if(adet == 0)
            {
                Console.WriteLine("değer bulunamadı");
            }
            else
            {
                Console.WriteLine("{0} adet {1} sayısı bulundu.", adet,sayi);
            }

            Console.ReadLine();

        }
    }
}
