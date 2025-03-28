using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eşittir_operatörü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // eşittir == matematikteki gibi
            int sayi1 = 5;
            int sayi2 = 5;
            bool eşitmi= sayi2 == sayi1;

            int a = 5;
            int b = 7;
            bool e = a == b;

            Console.WriteLine(e);
            Console.WriteLine(eşitmi);
            Console.ReadKey();


        }
    }
}
