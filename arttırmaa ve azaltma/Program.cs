using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arttırmaa_ve_azaltma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arttırma ++
            //azaltma --
            // eğer bi arttırıp bi azaltırsak normal sayıyı verir ya da bunun yerine iki kere arttırırsak 22 verir
            int sayi = 20;
            sayi--;
            sayi--;
            Console.WriteLine(sayi);
            Console.ReadKey();

        }
    }
}
