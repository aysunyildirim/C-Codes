using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilari_İfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //öğrenci notu 50 den büyükse başarılı değilse başarısız yazdır

            int not = 55;
            {
                if (not > 50)
                    Console.WriteLine("Öğrenci başarılı");

                else
                {
                    Console.WriteLine("Öğrenci başarısız");
                }

                int a = 30;
                if (a > 50)
                    Console.WriteLine("Matematikte başarılı");

                else
                {
                    Console.WriteLine("Matematikte başarısız");
                }
                Console.ReadLine(); 

            }
        }

    }
}

