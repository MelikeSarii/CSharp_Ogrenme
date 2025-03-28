using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace girilen_sayı_çigt_mi_tek_mi_diziler_örneği
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan 10 tane int değeri al
            //kaç çift kaç tek diye bak
            //çiftlerin toplamı
            //teklerin toplamı
            //hangisi büyük çıkarsa onu yazdırsın
            int çiftsayi=0;
            int teksayi = 0;
            int[] sayilar = new int[2];
            for (int i = 0; i <sayilar.Length ; i++)
            {
                sayilar[i] = Convert.ToInt16(Console.ReadLine());
                
            }
            for (int j = 0; j < sayilar.Length; j++)
            {


                if (sayilar[j] % 2 == 0)
                {
                    çiftsayi++;
                    int çifttoplamı = sayilar[j];
                    Console.WriteLine(çiftsayi);

                }
                else
                {
                    teksayi++;
                }

            }
            Console.WriteLine(çiftsayi);
            Console.

            Console.ReadLine();
        }
    }
}
