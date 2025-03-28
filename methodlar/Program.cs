using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //parametresiz ve geriye değer döndürmeyen metot
            // metotu içi kurşun dolu bi silah gibi düşün sen tetiğe basmadığın süreçte patlamaz yani çıktı olarak kullanılamaz
            selamke();
        }
        static void selamke()
        {
            Console.WriteLine("sellammm");
            Console.ReadLine();
        }
        // eğer mainde ben selamkeyi çağırmsaydım hiçbir çıktı vermezdi
    }
}
