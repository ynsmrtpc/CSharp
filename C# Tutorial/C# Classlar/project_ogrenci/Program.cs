using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_ogrenci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("İsminizi girin:");
            string ogrenci_isim = Console.ReadLine();

            Console.Write("Soyisminizi girin:");
            string ogrenci_soyisim = Console.ReadLine();

            Console.Write("Öğrenci numaranızı girin:");
            int ogrenci_number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Okulunuzun adını girin:");
            string ogrenci_okuladi = Console.ReadLine();

            Console.Write("1. Vize Notunuzu girin:");
            int ogrenci_vize1 = int.Parse(Console.ReadLine());

            Console.Write("2. Vize Notunuzu girin:");
            int ogrenci_vize2 = int.Parse(Console.ReadLine());

            Console.Write("Final Notunuzu girin:");
            int ogrenci_final = int.Parse(Console.ReadLine());

            Ogrenci ogrenci = new Ogrenci(ogrenci_number, ogrenci_isim, ogrenci_soyisim, ogrenci_vize1, ogrenci_vize2, ogrenci_final, ogrenci_okuladi);

            while (true)
            {
                Console.WriteLine("\n1 - Öğrenci Bilgilerini Göster\n2 - Öğrenci Ortalamasını Göster\n3 - Öğrencinin Okulunu Öğren\n4 - Çıkış Yap");
                Console.Write("\n\nYapmak istediğiniz işlemi seçiniz:");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 1)
                {
                    ogrenci.ogrenciBilgileriGoster();
                }

                else if (secim == 2)
                {
                    Console.WriteLine("\n****** Öğrenci ortalaması: {0}", ogrenci.ogrenciOrt_bul());
                }

                else if (secim == 3)
                {
                    Console.WriteLine("\n****** Öğrencinin okulunun adı: {0}", ogrenci.okulGetir());
                }

                else if (secim == 4)
                {
                    Console.WriteLine("Çıkış yapılıyor...");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
