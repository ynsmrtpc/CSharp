using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsulleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.setIsim("Yunus");
            Console.WriteLine(ogrenci.getIsim());
            Console.ReadLine();
        }
    }
}
