using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_döngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ifteki gibi şart var whileda da
            int a = 100;
            while(a>=0)
            {
                Console.WriteLine(a);
                a -= 2;
            }
            Console.ReadKey();
        }
    }
}
