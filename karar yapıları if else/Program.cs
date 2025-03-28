using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karar_yapıları_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // not 50den büyükse başarılı
            int not = 55;
            if (not<50)
            {
                Console.WriteLine("başarısız");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("başarılı");
                Console.ReadKey();
            }

            // birden fazla olay varsa else if kullanılır



        }
    }
}
