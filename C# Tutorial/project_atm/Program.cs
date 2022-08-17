using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_atm
{
    class Program
    {
        static void Main(string[] args)
        {
            int bakiye;

            Console.WriteLine("1.Bakiye Görüntüleme\n2.Para Çekme\n3.Para Yatırma\n4.Çıkış");
            Console.Write("Yapmak istediğiniz işlemi seçiniz:");

            int secim = Convert.ToInt32(Console.ReadLine());

            if (secim == 1)
            {
                Console.WriteLine("bakiye" + bakiye);
            }
            else if (secim == 2)
            {
                Console.WriteLine("bakiye:" + bakiye);
                Console.Write("Çekmek istediğiniz tuutarı girin:");
                double cek = Convert.ToDouble(Console.ReadLine());
                double cekimsonrasi = bakiye - cek;
                Console.WriteLine("çekim sonrası bakiye" + cekimsonrasi);
            }
            else if (secim == 3)
            {
                Console.WriteLine("bakiye:" + bakiye);
                Console.WriteLine("Yatırmak istediğiniz tutarı girin:");
                double yatir = Convert.ToDouble(Console.ReadLine());
                double yatirmasonrasi = bakiye + yatir;
                Console.WriteLine("yatırma sonrası bakiye:" + yatirmasonrasi);
            }
            else if (secim == 4)
            {
                Console.WriteLine("çıkış yapıldı.. iyi günler.. ");
            }
            Console.ReadLine();
         }
    }
}