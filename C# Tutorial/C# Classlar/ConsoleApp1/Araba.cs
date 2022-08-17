using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Araba
    {
        public int kapiSayisi;
        public string arabaModeli;
        public string arabaRengi;

        public void arabaCalistir()
        {
            Console.WriteLine("Araba çalıştırılıyor...");
        }

        // ctor yazıp tabtab yaparak constructor'umuz oluşur...
        public Araba(int araba_kapiSayisi, string araba_arabaModeli, string araba_arabaRengi)
        {
            kapiSayisi = araba_kapiSayisi;
            arabaModeli = araba_arabaModeli;
            arabaRengi = araba_arabaRengi;
        }

        public void kapilariKilitle()
        {
            Console.WriteLine("Kapılar kilitleniyor...");
        }
    }
}
