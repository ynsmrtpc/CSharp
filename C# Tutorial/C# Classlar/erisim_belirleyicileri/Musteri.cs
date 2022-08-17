using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erisim_belirleyicileri
{
    public class Musteri
    {
        public string isim;
        public string soyisim;
        public int maas;
        public string cinsiyet;
        public int d_tarih;
        private int yas;

        public Musteri()
        {
            Console.WriteLine("Müşteri methodunun yapıcı metodu.");
        }
        public void musteriBilgileri_goster()
        {
            Console.WriteLine("ismi:" + isim);
            Console.WriteLine("soyisim:" + soyisim);
            Console.WriteLine("Maaşı:" + maas);
            Console.WriteLine("Cinsiyeti:" + cinsiyet);
            Console.WriteLine("Yaşı:" + (2021 - d_tarih));
        }
        
        private void isimSoyisimYazdir(string musteri_isim, string musteri_soyisim)
        {
            Console.WriteLine("Müşterinin isim ve soyisimi: {0} {1}", musteri_isim,musteri_soyisim);
        }
             
        }
}
