using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break_ve_continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // break döngüyü komple bitirir
            // continue 1 kereliğine kırar ve sonra döngü devam eder

           /* for (int a= 1;a <=10; a++)
            {
                if (a==5)
                {
                    break;
                }
                Console.WriteLine(a);
                
            }
            Console.ReadLine();*/

            for (int b = 0; b <=10; b++)
            {
                if (b==7)
                {
                    continue;
                }
                Console.WriteLine(b);            }
            Console.ReadLine();

        }
    }
}
