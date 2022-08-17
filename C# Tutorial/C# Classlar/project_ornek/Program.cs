using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            Console.WriteLine("-------------------------");
            Console.WriteLine("\nDatabase Loglaması");
            Console.WriteLine("-------------------------");
            customerManager.Logger = new DatabaseLogger();
            customerManager.Add();
            Console.WriteLine("-------------------------");
            Console.WriteLine("\nMetin Dosyası Loglaması");
            Console.WriteLine("-------------------------");
            customerManager.Logger = new FileLogger();
            customerManager.Add();
            Console.WriteLine("-------------------------");
            Console.WriteLine("\nSMS Loglaması");
            Console.WriteLine("-------------------------");
            customerManager.Logger = new SmsLogger();
            customerManager.Add();
            Console.WriteLine("-------------------------");
            Console.ReadLine();

        }
    }

    class  CustomerManager
    {
        public ILogger Logger { get; set; }
        public void Add()
        {
            Logger.Log();
 /*           DatabaseLogger logger = new DatabaseLogger();
  *           logger.Log();      // bu şekilde yazılması kullanışlı değildir                         
 */
        Console.WriteLine("Customer Added");
        }
    }

    class DatabaseLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database!");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file!");
        }
    }

    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to SMS!");
        }
    }

    interface ILogger
    {
        void Log();
    }
}
