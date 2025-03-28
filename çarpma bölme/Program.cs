using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace çarpma_bölme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // çarpma *
            // bölme /
            // int olduğu için bölme yaparken tam kısmı veriyor ama sayıları ve işlemei double olarak tanımlarsak virgüllü olur
            double sayi1 = 5;
            double sayi2 = 6;
            double işlem2 = sayi2 / sayi1;
            double işlem = sayi1 * sayi2;
            Console.WriteLine(işlem);
            Console.WriteLine(işlem2);
            Console.ReadKey();
        }
    }
}
