using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kullanıcı_giriş_uygulaması__login_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcı adını ve şifresini doğru verirse tebrikler yazdır
            // 3 kere yanlış girme hakkı var yanlış girerse hata verelim
            int hak = 3;
            while (true)
            {
                Console.WriteLine("sisteme hoş geldiniz lütfen isminizi yazınız");
                string isim = Console.ReadLine();
                Console.WriteLine(" lütfen şifrenizi yazınız");
                int sifre = Convert.ToInt32(Console.ReadLine());
                 
                if(sifre==123&& isim== "melike")
                {
                    Console.WriteLine("sisteme giriş yapıldı");
                    break;
                }
                else 
                {
                    Console.WriteLine("şifreniz veya isminizi hatalı giriyorsunuz");
                    if(hak>0)
                    {
                        hak -= 1;

                    }
                    if (hak==0)
                    {
                        Console.WriteLine("sistem hata verdi!!");
                        break;

                    }
                }
                
                

             
                
            }
            Console.ReadKey();


        }
    }
}
