using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[]
            {
                new Worker(),
                new Manager()
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }

            Console.ReadLine();

        }

        // SOLID, INTERFACE SEGREGATION

        interface IWorker
        {
            void Work();
        }

        interface IEat
        {
            void Eat();
        }

        interface ISalary
        {
            void GetSalary();
        }

        class Manager : IWorker, IEat, ISalary
        {
            public void Work()
            {
                Console.WriteLine("Çalışıyor...");
            }

            public void Eat()
            {
                Console.WriteLine("Yemek yiyebiliyor...");
            }

            public void GetSalary()
            {
                Console.WriteLine("Maaş alabiliyor...");
            }
        }

        class Worker : IWorker, IEat, ISalary
        {
            public void Work()
            {
                Console.WriteLine("Çalışıyor...");
            }

            public void Eat()
            {
                Console.WriteLine("Yemek yiyebiliyor...");
            }

            public void GetSalary()
            {
                Console.WriteLine("Maaş alabiliyor...");
            }
        }

        class Robot:IWorker
        {
            public void Work()
            {
                Console.WriteLine("Çalışıyor...");
            }
        }
    }
}
