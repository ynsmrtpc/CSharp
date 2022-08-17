using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_ort_hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vize Notunuzu Giriniz(%40):");
            int vize = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ödev Notunuzu Giriniz(%10):");
            int odev = Convert.ToInt32(Console.ReadLine());

            Console.Write("Final Notunuzu Giriniz(%50):");
            int final = Convert.ToInt32(Console.ReadLine());

            double sonuc = ((vize * 0.4) + (odev * 0.1) + (final * 0.5));

            int ort = Convert.ToInt32(sonuc);
            Console.WriteLine("Genel Ortalamanız:" + ort);

            if (ort >= 80 && ort<=100)
            {
                Console.WriteLine("Harf Notunuz: A+");
            }

            else if (ort >=60 && ort < 80)
            {
                Console.WriteLine("Harf Notunuz: A");
            }

            else if (ort >=40 && ort < 60)
            {
                Console.WriteLine("Harf Notunuz: B+");
            }
            else if(ort < 40)
            {
                Console.WriteLine("Harf Notunuz: F");
                Console.WriteLine("Kaldınız!");
            }
            Console.ReadLine();
        }
    }
}
