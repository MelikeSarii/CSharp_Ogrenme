using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace değil_operatörü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //!
            // yani kısacası bi şeyi zıttına çevirir
            bool a = true;
            Console.WriteLine(!a);
            Console.ReadLine();
            // kodu ilk yazdığımda a yı direkt yazdım çıktısı true oldu ama başına ! koyunca çıktı false vermye başladı
        }
    }
}
