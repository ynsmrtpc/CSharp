using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Araba araba1 = new Araba(4, "BMW" , "Mat Siyah");

            Console.WriteLine("araba özellikleri\n" + araba1.kapiSayisi + " Kapılı\n" + araba1.arabaModeli + "\n" + araba1.arabaRengi);
            
            araba1.kapilariKilitle();
            araba1.arabaCalistir();


            Console.ReadLine();
        }
    }
}
