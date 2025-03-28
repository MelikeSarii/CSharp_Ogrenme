using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace float_ve_double
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // float doublea göre daha küçüktür ikisnde de negatif sayılar var galiba
            // ikisi de ondalıklı sayılar içindir
            // float yapacaksak sayının sonuna f yazmak zorundayız yoksa double olarak algılıyor ve hata veriyor
            float sayi = 5.7f;
            Console.WriteLine(sayi);
            double sayi2 = 894.589;
            Console.WriteLine(sayi2);
            Console.ReadLine();



        }
    }
}
