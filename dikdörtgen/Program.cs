using NBitcoin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dikdörtgen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye, yatirilan, cekilen;
            string hesap;
            char choice;
            Console.WriteLine("Hesap Numaranız: ");
            hesap = Console.ReadLine();
            Console.WriteLine("Bakiyeniz: ");
            bakiye = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yatırılacak Para Miktarını giriniz:");
            yatirilan = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Çekilecek para miktarını giriniz:");
            cekilen = Convert.ToInt32(Console.ReadLine());




            for (; ; )
            {
                do
                {
                    Console.WriteLine("Özcan Bankaya Hoşgeldiniz,"+ hesap  +" Size nasıl yardımcı olabiliriz?:");
                    Console.WriteLine("  1. Bakiye");
                    Console.WriteLine("  2. Para Yatır");
                    Console.WriteLine("  3. Para Çek");
                    Console.WriteLine("  4. Bakiye Sıfırla");
                    
                    do
                    {
                        choice = (char)Console.Read();
                    } while (choice == '\n' | choice == '\r');
                } while (choice < '1' | choice > '5' & choice != 'q');

                if (choice == 'q') break;

                Console.WriteLine("\n");

                switch (choice)
                {
                    case '1':
                        
                        Console.WriteLine("Bakiyeniz:" + Convert.ToString( bakiye) + "liradır.");
                        
                        break;
                    case '2':
                        
                        
                        Console.WriteLine( Convert.ToString( yatirilan) +"lira hesabınıza yatırılmıştır.");
                       
                        bakiye = bakiye + yatirilan;
                        

                        break;
                    case '3':
                        
                        Console.WriteLine("Hesabınızdan"+ Convert.ToString(cekilen)+ "lira çekilmiştir.");
                        bakiye = bakiye - cekilen;
                        
                        break;
                    case '4':
                        Console.WriteLine("Bakiyeniz sıfırlanmıştır.");
                        bakiye = 0;
                        Console.WriteLine(Convert.ToString(bakiye));

                        break;

                    
                }
                Console.WriteLine();
            }
            
            



            
            
            
        }
    }
}
