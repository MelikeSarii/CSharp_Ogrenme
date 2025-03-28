using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eşit_değil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // eşit değildir operatörü != dir
           /// yazdığım kod true oldu çünkü 4 9 a eşit değildir ve bizim operatör de zaten eşit değildir demek istiyor
           // sayılar eşit olsaydı false olurdu
            int a = 4;
            int b = 9;
            bool k = a != b;
            Console.WriteLine(k);
            Console.ReadLine();


        }
    }
}
