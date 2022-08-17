using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_personel_tc2
{
    class Program
    {
        static void Main(string[] args)
        {
//            Console.Write("tc kimlik no girin: ");
            Personel personel = new Personel();

//           string tc_no = Console.ReadLine();
            personel.TC = "12345678910";

            Console.WriteLine("tc kimlik no(ilk 5 hane): " + personel.TC);
        }
    }
}
