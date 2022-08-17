using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Yunus Emre");
            Console.Write("Topçu");
            Console.Write(" 123\n");

            byte minValue = byte.MinValue;
            byte maxValue = byte.MaxValue;

            Console.WriteLine("\nbyte minValue: " + minValue);
            Console.WriteLine("byte maxValue: " + maxValue);

            short minShort = short.MinValue;
            short maxShort = short.MaxValue;
            Console.WriteLine("\nshort minValue: " + minShort);
            Console.WriteLine("short maxValue: " + maxShort);

            int minInt = int.MinValue;
            int maxInt = int.MaxValue;
            Console.WriteLine("\nint minValue: " + minInt);
            Console.WriteLine("int maxValue: " + maxInt);

            long minLong = long.MinValue;
            long maxLong = long.MaxValue;
            Console.WriteLine("\nlong minValue: " + minLong);
            Console.WriteLine("long maxValue: " + maxLong);

            float minFloat = float.MinValue;
            float maxFloat = float.MaxValue;
            Console.WriteLine("\nfloat minValue: " + minFloat);
            Console.WriteLine("float maxValue: "    + maxFloat);
            Console.ReadLine();
        }
    }
}
