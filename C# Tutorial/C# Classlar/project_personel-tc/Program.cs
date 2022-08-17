using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_personel_tc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("tc girin:");
            Personel personel = new Personel();

            personel.TC = Console.ReadLine();

            Console.WriteLine("\n\n {0} \n\n", personel.TC);

            Console.ReadLine();
        }
    }
}
