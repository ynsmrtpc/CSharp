using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();

            musteri.Tc = 12345678910;
            Console.WriteLine(musteri.Tc);
            Console.ReadLine();

        }
    }
}
