using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_döngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for döngüsü 3 adımdan oluşur 
            // 1- değişkenin türüyle birlikte adını yaz; 2- başlangıç değerini gir;3- + ya da - olduğunun yaz
            // for döngüsü ilk çalışmaya başladığında arttırmadan a değerini yazdırı sonra arttırmmya ya da azaltmaya başlatır

            for(int a=0; a<=10; a=a+2)
            {
                Console.WriteLine(a);

            }
            Console.ReadLine();



        }
    }
}
