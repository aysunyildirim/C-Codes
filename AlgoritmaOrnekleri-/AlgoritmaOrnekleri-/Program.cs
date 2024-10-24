
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmaOrnekleri_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Birbirinden ffarklı iki sayıdan büyük olanı bul.

            //a sayısı b sayısı var . tanımla.
            Console.WriteLine("a sayısını giriniz:"); //string değer
            int a = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("b sayısını giriniz:");
            int b = Convert.ToInt32 (Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("a sayısı büyüktür");

            }

            else if (a==b)
            {
                Console.WriteLine("sayılar eşittir");
            }

            else
            {
                Console.WriteLine("b sayısı büyüktür");
            }
            Console.ReadLine();

                        }
    }
}
