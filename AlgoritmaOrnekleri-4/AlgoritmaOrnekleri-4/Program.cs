using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmaOrnekleri_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //verilen tamsayının sıfır negatif ya da pozitif olup olmadıgını
            //adim 1 basla
            //sayiyi gir sayi1
            //eger sayi1>0 pozitif
            //Eger Sayi1<0 negatif 
            //degilse 0 yaz.

            Console.WriteLine("1.sayıyı giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 > 0)
            {
                Console.WriteLine("sayi pozitif");
               
            }
            else if(sayi1<0)
                {
                Console.WriteLine("sayi negatif");

            }
            else
            {
                Console.WriteLine("0 yaz");
            }
            Console.ReadLine(); 
        }
    }
}
