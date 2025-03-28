using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beden_kitle_indeksi_uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //beden kitle indeksi=kilo/ boy*boy
            //18 e eşit veya düşükse zayıf
            // 18-25 arası normal
            // 25 ten büyükse kilolu
            Console.WriteLine("lütfen kilonuzu girniz");
            int kilo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("lütfen boyunuzu girniz");
            int boy = Convert.ToInt32(Console.ReadLine());
            int indeks = (kilo / boy * boy);
            if (indeks<=18)
            {
                Console.WriteLine("zayıfsınız");
                Console.ReadKey();
            }
            else if (indeks>18 && indeks<=25)
            {
                Console.WriteLine("normalsiniz");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("kilolusunuz");
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
