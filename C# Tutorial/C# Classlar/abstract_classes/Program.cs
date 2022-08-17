using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Database database = new Database();  --- şeklinde yazamayız... aynı interfacelerde olduğu gibi

            Database database = new SqlServer();
            database.Add();
            database.Delete();

            Database database2 = new Oracle();
            database2.Add();
            database2.Delete();

            Console.ReadLine();
        }
    }

    abstract class Database     // bir senaryo düşünelim
        {
            public void Add()           // tüm database'lerde ekleme methodu aynı olsun
            {
                Console.WriteLine("Added by default...");
            }

            public abstract void Delete();      // fakat silme methodu farklı olsun
        }
    

    class SqlServer : Database              // delete methodu içi boş olduğu için hata verecektir
    {
        public override void Delete()           // implement abstract class'a tıkladıktan sonra hata düzelecektir..
        {
            Console.WriteLine("Deleted by SQL");  // abstractlar içi dolu olmayan virtual methodlardır
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}
