using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_if_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            int not = 40;
            if(not < 50)
            {
                Console.WriteLine("Dersten kaldı.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Dersten geçti.");
            }
        }
    }
}
