using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence
{
    class Kedi : Hayvan
    {
        public string kedi_cinsi;

        public void kediCinsiYazdir()
        {
            Console.WriteLine("Kedinin cinsi: " + kedi_cinsi);
        }
    }
}
