using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace girilen_sayının_ortalamsının_toplamı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("lütfen sayı yazınız");
            int a = 0;

            int sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= sayi; i++)
            {
                a = i+a;
               
            }
            double ortalama = (a / sayi);
            Console.WriteLine(a);
            Console.WriteLine(ortalama);
            if (ortalama<50)
            {
                Console.WriteLine("ortalama 50 den küçük");
            }
            else if(ortalama >50)
            {
                Console.WriteLine("ortalama 50den büyük");
            }
            Console.ReadKey();
        }
            
    }
}
