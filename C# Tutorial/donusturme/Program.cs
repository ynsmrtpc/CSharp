using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donusturme
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi1 = "1";
            string sayi2 = "2";

            // INT VERI TIPINDEN STRING VERI TIPINE DÖNÜŞTÜRME

            Console.WriteLine(sayi1 + sayi2);

            /*         int a = int.Parse(sayi1);
                       int b = int.Parse(sayi2);*/

            int a = Convert.ToInt32(sayi1);
            int b = Convert.ToInt32(sayi2);

            Console.WriteLine(a+b);
//            Console.ReadLine();

            // INT VERI TIPINDEN STRING VERI TİPİNE DÖNÜŞTÜRME

            int num1 = 5;
            int num2 = 10;
            string x = num1.ToString();
            string y = num2.ToString();

            Console.WriteLine(x+y);
            //          Console.ReadLine();

            Console.Write("1. sayıyı giriniz:");
            int sayi_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz:");
            int sayi_2 = Convert.ToInt32(Console.ReadLine());

            int toplam = sayi_1 + sayi_2;
            Console.WriteLine(toplam);
            Console.ReadLine();
        }
    }
}
