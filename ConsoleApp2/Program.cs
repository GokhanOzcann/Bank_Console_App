using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad;
            
            Console.WriteLine("Adınız:");
            ad = Console.ReadLine();
            Console.WriteLine("Soyadınız:");
            soyad = Console.ReadLine();
            
            
            Console.WriteLine("Merhaba" + " " + ad + " " + soyad );
            Console.ReadKey();

        }
    }
}
