using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kullanıcıdan_değer_alma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // readlinela yapılır
            Console.WriteLine("lütfen isminizi yazınız");
            string isim = Console.ReadLine();
            Console.WriteLine("lütfen soyisminizi yazınız");
            string soyisim = Console.ReadLine();
            Console.Write("isim soyisim :" + isim );
            Console.WriteLine( soyisim );
            Console.ReadKey();
        }
    }
}
