using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @short
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -32768 ile 32767 arasını tutar
            short enbüyükshort = short.MaxValue;
            short enminnakshort = short.MinValue;
            Console.WriteLine(enminnakshort);
            Console.WriteLine(enbüyükshort);
            Console.ReadLine();
        }
    }
}
