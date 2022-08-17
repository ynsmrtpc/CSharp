using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_alis_satis_kar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Urunun alis fiyatini giriniz:");
            double alisfiyati = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(alisfiyati);
            Console.WriteLine("Kar oranini giriniz:");
            double karorani = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(karorani);

            double fiyat = (((alisfiyati * karorani) / 100) + 10);

            Console.WriteLine("\nUrunun satis fiyati: " + fiyat);
            //Console.ReadLine();
        }
    }
}
