using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_beden_kitle_indeksi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kilonu gir:");
            double kilo = Convert.ToDouble(Console.ReadLine());
            Console.Write ("Boyunu gir:");
            double boy = Convert.ToDouble(Console.ReadLine());

            double bki = kilo / (boy * boy);

            if (bki <= 18)
            {
                Console.WriteLine("zayıfsın");
            }
            else if (bki <= 25 && bki > 18)
            {
                Console.WriteLine("normalsin");
            }
            else if (bki > 25)
            {
                Console.WriteLine("obezsin");
            }
            Console.ReadLine();
        }
    }
}
