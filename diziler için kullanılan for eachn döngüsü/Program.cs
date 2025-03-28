using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler_için_kullanılan_for_eachn_döngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "melike", "yasemin", "elif", "zeynep" };
            foreach (string a in isimler)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();


            // aslında forla da yazdırabiliriz ama diziler için bu döngü kullanılıyormuş daha çok
        }
    }
}
