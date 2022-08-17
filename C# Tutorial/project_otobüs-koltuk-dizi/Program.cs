using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_otobüs_koltuk_dizi
{
    class Program
    {
        static void Main(string[] args)
        {
            // ÇİFT SAYILI KOLTUKLARI DOLU OLAN BİR OTOBÜS 

            int[] koltuk_sayisi = new int[32];

            for (int i = 0; i < 32; i++)
            {
                if(i%2==0)
                    koltuk_sayisi[i] = 1;
            }

            for (int i = 0; i < 32; i++)
            {
                if(i%2!=0)
                    koltuk_sayisi[i] = 0;
            }


            for (int i = 0; i < 32; i++)
            {
                if (koltuk_sayisi[i] == 1) 
                {
                    string koltuk = "Dolu";
                }
                else
                {
                    string koltuk = "Boş";
                }
;            }
            Console.Write
                ("İstediğiniz koltuk numarasını giriniz:");
            int musteri_koltuk = Convert.ToInt32(Console.ReadLine());

            if(koltuk_sayisi[musteri_koltuk] == 0)
            {
                Console.WriteLine("Seçtiğiniz koltuk numarası boş. Bu numaradan koltuk alabilirsiniz.");
            }

            else if (koltuk_sayisi[musteri_koltuk] == 1)
            {
                Console.WriteLine("Maalesef.. Seçtiğiniz koltuk numarası dolu.");
            }
            Console.ReadLine();
        }
    }
}
