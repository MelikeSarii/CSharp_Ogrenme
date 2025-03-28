using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ek_operatör
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // +=
            // -=
            // /=
            // *=

            int a = 8;
            a -= 5;

            int b = 12;
            b /= 6;

            int c = 10;
            c *= 2;

            int d = 2;
            d += 17;

            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
