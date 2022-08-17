using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Kedi kedi = new Kedi();

            kedi.hayvan_ismi = "Tekir";
            kedi.hayvan_cinsi = "Kedi";
            kedi.hayvan_rengi = "Siyah";
            kedi.hayvan_yas = 5;
            kedi.kedi_cinsi = "Maine Coon";
            kedi.hayvan_bilgi_goster();

            Console.ReadLine();
        }
    }
}
