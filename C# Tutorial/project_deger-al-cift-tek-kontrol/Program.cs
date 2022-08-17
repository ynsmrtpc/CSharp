using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_deger_al_cift_tek_kontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] kullanici_dizi = new int[10];
            int adet_cift = 0, adet_tek = 0, toplam_tek = 0, toplam_cift = 0;
            for (int i = 0; i < kullanici_dizi.Length; i++)
            {
                Console.Write("{0}. Sayıyı Giriniz:", i + 1);
                kullanici_dizi[i] = Convert.ToInt32(Console.ReadLine());

                if (kullanici_dizi[i] % 2 == 0)
                {
                    toplam_cift += kullanici_dizi[i];
                    adet_cift++;
                }
                else
                {
                    toplam_tek += kullanici_dizi[i];
                    adet_tek++;
                }
            }

            Console.WriteLine("\n* Girdiğiniz sayılar içerisinde {0} adet tek, {1} adet çift sayı vardır." , adet_tek, adet_cift);
            Console.WriteLine("* Tek Sayıların toplamı {0}, çift sayıların toplamı ise {1}'dir.", toplam_tek, toplam_cift);
            if (toplam_cift>toplam_tek)
            {
                Console.WriteLine("* Çift sayıların toplamı tek sayıların toplamından büyüktür.");
            }
            else if (toplam_tek == toplam_cift)
            {
                Console.WriteLine("* Çift sayıların toplamı tek sayıların toplamına eşittir.");
            }
            else
            {
                Console.WriteLine("* Tek sayıların toplamı çift sayıların toplamından büyüktür.");
            }
            Console.ReadLine();
        }
    }
}
