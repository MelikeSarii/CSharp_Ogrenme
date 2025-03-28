using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace çarpım_tablosu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=10; i++)
            {
                for (int a= 1; a <=10; a++)
                {
                    int yazdir = a * i;
                    Console.WriteLine(yazdir);
                }
               
            }

            Console.ReadLine();

        }
    }
}
