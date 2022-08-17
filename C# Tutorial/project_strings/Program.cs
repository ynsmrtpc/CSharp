using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_strings
{
    class Program
    {
        // "KERİM, ŞARKI DİNLEMEYE BAYILIR" CÜMLESİNDEKİ KELİMELERİN CÜMLEDE VAR OLUP OLMADIĞINI KONTROL EDİP HANGİ KELİME İLE BAŞLAYIP BİTTİĞİNİN KONTROLÜNÜ 
        //  YAPAN PROGRAM
        static void Main(string[] args)
        {
            string str = "Kerim şarkı dinlemeye bayılır";
            bool start = str.StartsWith("Kerim");
            bool end =   str.EndsWith("bayılır");
            bool control = str.Contains("şarkı");

            bool f_start = str.StartsWith("Ali");
            bool f_end = str.EndsWith("sevmez");
            bool f_control = str.Contains("müzik");

            Console.WriteLine(start); // true
            Console.WriteLine(end);   // true
            Console.WriteLine(control);// true
            Console.WriteLine(f_start); //false
            Console.WriteLine(f_end);   // false
            Console.WriteLine(f_control); // false
            Console.ReadLine();
        }
    }
}
