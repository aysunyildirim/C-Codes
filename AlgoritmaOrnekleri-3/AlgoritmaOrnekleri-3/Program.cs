using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmaOrnekleri_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bir öğrencinin 2 notunun ortalamasını hesaplayan ve sonuca göre not iyi ya da kötü
            //1. not a yı gir
            // 2 . not b y gir.
            // 3. not ortalamayı gir.
            // 4. adım not if(ort>55) not iyi de 
            //5.adım not ort 55 den küçükse kötü de.

            Console.WriteLine("Not a yı giriniz: ");
            double a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Not b yi giriniz");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ortalamasını giriniz : ");
            double ortalama = (a + b) / 2;

            if (ortalama >= 55)
            {
                Console.WriteLine("Not ortalaması geçerli");
            }
            else 
            {
                Console.WriteLine("Not ortalaması geçersiz.");
            }
            Console.ReadLine();
        }
    }
}
