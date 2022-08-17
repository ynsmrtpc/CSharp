using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erisim_belirleyicileri
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.isim = "yunus";
            musteri.soyisim = "topcu";
            musteri.maas = 2500;
            musteri.cinsiyet = "erkek";
            musteri.d_tarih = 1998;

            musteri.musteriBilgileri_goster();
            Console.ReadLine();
        }
    }
}
