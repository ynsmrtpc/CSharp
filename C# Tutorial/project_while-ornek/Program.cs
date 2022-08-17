using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_while_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            // 100 DEN KÜÇÜK ÇİFT SAYILARI YAZDIRMA 1. YÖNTEM
            int a = 0;
            //while (a <= 100)
            //{
            //    if (a % 2 == 0)
            //    {
            //        Console.Write(a + " - ");

            //    }
            //    a++;
            //}
            
            // 100 DEN KÜÇÜK ÇİFT SAYILARI YAZDIRMA 2. YÖNTEM 

            while (a <= 100)
            {
                Console.Write(a +" - ");
                a += 2;
            }

            Console.ReadLine();
        }
    }
}
