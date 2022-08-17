using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_for_each
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç adet hayvan cinsi yazacağınızı söyleyin:");
            int hayvan_adet = Convert.ToInt32(Console.ReadLine());
            string[] hayvanlar = new string[hayvan_adet];

            for (int i = 0; i < hayvanlar.Length; i++)
            {
                Console.Write("{0}. hayvanın cinsini giriniz:" , (i+1));
                hayvanlar[i] = Console.ReadLine();
            }

            foreach(string a in hayvanlar)
            {
                Console.Write(" - " + a + " - ");
            }
            Console.ReadLine();
        }
    }
}
