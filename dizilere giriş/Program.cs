using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizilere_giriş
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // dizi yazacaksak [] kullanırız
            // dizide 1. eleman 0. indekstir dır
            int[] sayilar = new int[3];
            sayilar[0] =3;
            sayilar[1] = 5;
            sayilar[2] = 12;
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            Console.ReadLine();

        }
    }
}
