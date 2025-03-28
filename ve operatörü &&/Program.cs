using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ve_operatörü___
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // && ve demektir bütün koşullar doğruysa doğru döndürür

            int a = 5;
            int b = 0;
            int d = 59;
            bool c = a + b == d && d > a;
            Console.WriteLine(c);
            Console.ReadKey();

        }
    }
}
