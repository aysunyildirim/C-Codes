using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToplamaCikarma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 5;
            int sayi2 = 12;

            int sonuc = sayi1 + sayi2;  
            Console.WriteLine(sonuc);



            // Carpma ve bolme islemleri

            int sayi4 = 7;
            int sayi5 = 13;

            int sonuc2 = sayi4 * sayi5 ;

            Console.WriteLine(sonuc2);

            int sayiA = 1;
            int sayiB = 5;

            int sonuc3= 5 / 1;

            Console.WriteLine(sonuc3);

            //Mod alma operatörü
            int sayiM = 90;
            int sayiN = 10;

            Console.WriteLine(sayiM % sayiN);
         


        
            Console.ReadLine();
        }
    }
}

