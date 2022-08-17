using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence
{
    class Hayvan
    {
        public string hayvan_ismi;
        public string hayvan_cinsi;
        public string hayvan_rengi;
        public int hayvan_yas;

        Kedi kedi1 = new Kedi();


        public void hayvan_bilgi_goster()
        {
            Console.WriteLine("hayvan adı: " + hayvan_ismi);
            Console.WriteLine("hayvan cinsi: " + hayvan_cinsi);
            Console.WriteLine("hayvan rengi: " + hayvan_rengi);
            Console.WriteLine("hayvan yasi: " + hayvan_yas);
            kedi1.kediCinsiYazdir();
        }
    }
}
