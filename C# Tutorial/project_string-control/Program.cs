using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_string_control
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Bir cümle yazınız:");
                string cumle = Console.ReadLine();
                if (cumle == "q")
                    break;
                control_contain(cumle);
                control_start(cumle);
                control_end(cumle);
                Console.WriteLine("Devam etmek için herhangi bir tuşa, çıkmak için q'ya basınız...");
                Console.ReadLine();
            }
        }
        static string tutucu(string str)
        {
            string aranan = Console.ReadLine();
            return aranan;
        }
        static string control_aranan(string str)
        {
            Console.Write("Hangi kelimeyi aramak istiyordunuz? ->");
            string aranan = tutucu(str);
            return aranan;
        }
        static string control_contain(string str)
        {
            string aranan = control_aranan(str);
            if (str.Contains(aranan))
            {
                Console.WriteLine("\n* * *  TEBRİKLER..." + aranan + " kelimesi cümlenizin içinde bulunuyor.");
            }
            else
            {
                Console.WriteLine("\n! ! !  MAALESEF..." + aranan + " kelimesi cümlenin içinde bulunmuyor.");
            }
            return aranan;
        }
        static void control_start(string str)
        {
            Console.Write("Hadi cümlenizin hangi kelime ile başladığını kontrol edelim. ->");
            string aranan = tutucu(str);

            if(str.StartsWith(aranan))
            { 
                Console.WriteLine("\n* * * TEBRİKLER...Cümleniz {0} kelimesi ile başlıyor.", aranan);
            }
            else
            {
                Console.WriteLine("\n! ! ! MAALESEF...Cümleniz {0} kelimesi ile başlamıyor.", aranan);
            }
        }

        static void control_end(string str)
        {
            Console.Write("Hadi cümlenizin hangi kelime ile bittiğini kontrol edelim. ->");
            string aranan = tutucu(str);
            if (str.EndsWith(aranan))
            {
                Console.WriteLine("\n* * * TEBRİKLER...Cümleniz {0} kelimesi ile bitiyor.", aranan);
            }
            else
            {
                Console.WriteLine("\n! ! ! MAALESEF...Cümleniz {0} kelimesi ile bitmiyor.", aranan);
            }
        } 
    }
}