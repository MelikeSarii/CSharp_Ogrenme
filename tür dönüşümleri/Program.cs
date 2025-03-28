using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tür_dönüşümleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int 500 ü kabul eder ama byte 255e kadar o yüzden çıktıda değer kaybı yaşarız
            /*int a = 500;
            byte b = (byte)a;

            Console.WriteLine(b);
            Console.WriteLine(b.GetType());
            Console.ReadLine();*/

            // STRİNGTEN İNTE DÖNÜŞTÜRME
            // eğer inte dönüştürmeseydim çıktı 13 olurdu
            /*string sayi = "1";
            string sayi2 = "3";
            int a = int.Parse(sayi);
            int b = int.Parse(sayi2);
            Console.WriteLine(a + b);
            Console.ReadKey();*/

            // convert.toint32 de yazabiliriz
            // int a= convert.toint32(sayi1); gibi

            // İNTTEN STRİNGE DÖNÜŞTÜRME

            /*  int sayi1 = 5;
              int sayi2 = 8;
              string a = sayi1.ToString();
              string b = sayi2.ToString();
              Console.WriteLine(a + b);
              Console.ReadLine();*/


            // DOUBLEDAN İNTE DÖNÜŞTÜRME
            // virgülü yuvarlıyor çıktı 6 verir
            /* double sayi = 5.92;
             int c = Convert.ToInt32(sayi);
             Console.WriteLine(c);
             Console.ReadLine();*/


            // kullanıcadan aldığımız bütün değerler kep string olur 

            //kullanıcıdan 2 değer alıp toplamını yazdır
            Console.WriteLine("lütfen 1. sayıyı yazınız");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("lütfen 2. sayıyı yazınız");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int islem = sayi1 + sayi2;
            Console.WriteLine(islem);
            Console.ReadKey();

            // ToString();
            //Convert.ToInt();
            //int.Parse();
            //doubleparse();
            //(int);


        }
    }
}
