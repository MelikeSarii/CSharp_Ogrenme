using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace else_if_örneği
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıda 3 tane not alan ve bunların ortalamasını alıp derecelendiren kodu yaz
            Console.WriteLine("lütfen 1. notu giriniz");
            int not1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("lütfen 2. notu giriniz");
            int not2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("lütfen 3. notu giriniz");
            int not3 = Convert.ToInt32(Console.ReadLine());

            int islem = (not1 + not2 + not3) / 3;

            if (islem > 85)
            {
                Console.WriteLine("a+");
                Console.ReadKey();
            }
            else if (islem >= 75 && islem < 85)
            {
                Console.WriteLine("a");
                Console.ReadKey();
            }
            else if (islem < 75 && islem > 50)
            {
                Console.WriteLine("b");
                Console.ReadKey();
            }
            else 
            
            {
                Console.WriteLine("c");
                Console.ReadKey();
            }
        }
    }
}
