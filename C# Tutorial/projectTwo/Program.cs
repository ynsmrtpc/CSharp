using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            float sayi1 = 3.56f;
            float sayi2 = 12.5f;

            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);
//            Console.ReadLine();

            double d_sayi1 = 350.54;
            double d_sayi2 = -250.6;
            Console.WriteLine(d_sayi1);
            Console.WriteLine(d_sayi2);
 //          Console.ReadLine();

            double minDouble = double.MinValue;
            double maxDouble = double.MaxValue;
            Console.WriteLine("Double minValue: " + minDouble);
            Console.WriteLine("Double MaxValue: " + maxDouble);
 //           Console.ReadLine();

            char character  = 'Y';
            char character2 = '?';
            Console.WriteLine(character);
            Console.WriteLine(character2);
//           Console.ReadLine();

            string name = "Yunus";
            string surname = "Topcu";
            string id = "1234567890";
            int i_id = 1234567890;
            Console.WriteLine(name);
            Console.WriteLine(surname);
            Console.WriteLine(id);
            Console.WriteLine(i_id); 
            Console.WriteLine(id + 5);
            Console.WriteLine(i_id + 5);
//           Console.ReadLine();

            bool control  = true;
            bool control2 = false;

//          bool control3 = "Emre"; -- Sadece true-false tutar.

            bool sonuc = 20 > 5;
            bool sonuc2 = 15 < 13;
            Console.WriteLine(sonuc);
            Console.WriteLine(sonuc2);
            Console.ReadLine();

         }
    }
}
