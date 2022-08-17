using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsulleme_deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "emre";
            ogrenci.Tc = 12345678910;
            Console.WriteLine(ogrenci.Isim + " " + ogrenci.Tc);
            Console.ReadLine();
        }
    }
}
