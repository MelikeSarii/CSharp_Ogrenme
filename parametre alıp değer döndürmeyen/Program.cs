using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parametre_alıp_değer_döndürmeyen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // geri değer döndürmeyen ama parametre alan metotlarrr
            toplama(5,9);
            isimler("m", "sari");
        }
        static void toplama(int a,int b)
        {
            Console.WriteLine(a + b);
            
            
            Console.ReadKey();
                 

        }
        static void isimler(string isim, string soyisim)
        {
            Console.WriteLine(isim + soyisim);
            Console.ReadKey();
        }
        // a ve b ye sadece toplamanın içinmde ulaşabiliriz yani başka metotlarda da a ve b kullansak farklı a ve b olur
    


    }
}
