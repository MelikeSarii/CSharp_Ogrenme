using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @byte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // byte 0 ile 256 arasını tutar yani 256yı yazdıramayız
            byte birinci = 5;
            byte enbüyükbyte = byte.MaxValue;
            byte enminnakbyte = byte.MinValue;
            Console.WriteLine(enbüyükbyte);
            Console.WriteLine(enminnakbyte);
            Console.WriteLine(birinci);
            Console.ReadLine();
        }
    }
}
