using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kullanıcının_girdiği_değer_dizide_var_mı_varsa_kaç_tane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int var = 0;
            int varmi;
            int[] sayilar = { 10, 10, 10, 25, 26, 29, 300, 300, 79, 79, 79, 79, 79 };
            varmi = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i <sayilar.Length; i++)
            {

                if (varmi == sayilar[i])
                {
                    var++;
                    
                }
             
            }
            if (var==0)
            {
                Console.WriteLine("girdiğiniz sayi yok");

            }
            else
            {
                Console.WriteLine("girdğiniz sayi" + var + "kere var");
            }
            Console.ReadLine();

        }
    }
}
