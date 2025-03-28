using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //koşulu sağlamasa bile 1 kereliğine çalışır

            /*int a = 1;
            int toplam=0;
            do
            {
                toplam += a;
                a++;
            } while (a <= 100);
            Console.WriteLine(toplam);
            Console.ReadKey();*/

            int a = 5;
            int toplam = 0;
            do
            {
                toplam += a;
                a++;
            } while (a <= 4);
            Console.WriteLine(toplam);
            Console.ReadKey();
         // görüldüğü gibi 5 4 ten küçük değil ama şart döngünün sonunda olduğu için bi kereliğine mecbur çalıştı ve ekrana 5 yazdırdı
        }
    }
}
