using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylists
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList collection = new ArrayList();

            for (int i = 0; i < 10; i++)
            {
                collection.Add(i+1);
            }

            Console.WriteLine("\neleman sayisi: " + collection.Count);

            foreach (var item in collection)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n5 var mı?: " + collection.Contains(5));

            collection.Remove(5);

            foreach (var item in collection)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\neleman sayisi: " + collection.Count);

            Console.WriteLine("5 var mı?: " + collection.Contains(5));
            Console.WriteLine("10 var mı?: " + collection.Contains(10));

            Console.WriteLine("7'nin index numarası: " + collection.IndexOf(7));

            collection.Insert(5, "yunus");
            Console.WriteLine("\n\nyunus eklendikten sonra... \n\n");
            foreach (var item in collection)
            {
                Console.Write(item + " ");
            }

            collection.Reverse();

            Console.WriteLine("\n\nters çevrildikten sonra\n");

            foreach (var item in collection)
            {
                Console.Write(item + " ");
            }

            ArrayList sayilar = new ArrayList();
            sayilar.Add(6);
            sayilar.Add(16);
            sayilar.Add(5);
            sayilar.Add(54);
            sayilar.Add(20);
            sayilar.Add(36);
            sayilar.Add(7);
            sayilar.Add(0);
            sayilar.Add(9);

            Console.WriteLine("\n\nSıralanmadan önce...\n");
            foreach (var item in sayilar)
            {
                Console.Write(item + " ");
            }

            sayilar.Sort();

            Console.WriteLine("\n\nSıralanmadan sonra...\n");
            foreach (var item in sayilar)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
