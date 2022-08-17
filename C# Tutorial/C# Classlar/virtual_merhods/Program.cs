using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace virtual_merhods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySql mySql = new MySql();
            mySql.Add();

            Console.ReadLine();
        }
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }

        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }

    class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by SQL Server");       // virtual method bu şekilde değişiklik yapmaya yarar. override kullanılarak yapılır.
            base.Add();
        }
    }
    class MySql : Database
    {

    }
}
