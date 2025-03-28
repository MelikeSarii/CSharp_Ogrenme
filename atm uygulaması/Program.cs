using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm_uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıya nasıl işlem yapmak istediğini sor
            //1 bakiye görüntüleme
            //2 para çekme 
            //3 para yatırma
            // q çıkış olsun

            Console.WriteLine("hoş geldiniz,lütfen yapmak istediğiniz işlemi yazınız");
            Console.WriteLine("1- bakiye görüntüleme");
            Console.WriteLine("2- para çekme");
            Console.WriteLine("3- para yatırma");
            Console.WriteLine("4 çıkış");
            int bakiye = 257;
            
            int islem =Convert.ToInt16( Console.ReadLine());
            if (islem==1)
            {
                Console.WriteLine(" bakiye= 257 tl");
                Console.ReadKey();
            }
            else if(islem==2)
            {
                Console.WriteLine("çekmek istediğiniz para miktarını yazınız");
                int çekilenpara = Convert.ToInt16(Console.ReadLine());
                if (çekilenpara<=bakiye)
                {
                    int yenibakiye = (bakiye - çekilenpara);
                    Console.WriteLine("kalan paranız=" + yenibakiye);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("hesabınızda yeterli bakiyue yok!!!");
                }
                


            }
            else if (islem==3)
            {
                Console.WriteLine("lütfen yatırmak sitediğiniz para miktarını girniz");
                int yatırılanpara = Convert.ToInt16(Console.ReadLine());
                int sondurum = (bakiye + yatırılanpara);
                Console.WriteLine("güncel bakiyeniz=" + sondurum);
                Console.ReadKey();
            }
            else if( islem==4)
            {
                Console.WriteLine("çıkış yapıldı");
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
