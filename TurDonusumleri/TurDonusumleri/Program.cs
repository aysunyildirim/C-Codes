using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;

            byte b = (byte)a;
            Console.WriteLine(b);
        


            //string sayılar toplamanamaz.İnt veri tipine dönüştürürüz.
            //2 tane şekli var int parse ve convert.to ınt 32 şeklinde

            string sayi1 = "1";
            string sayi2 = "2";

            //int a = int.Parse(sayi1);
            //int b = int.Parse(sayi2);
            //Console.WriteLine(a+b);

            int m = Convert.ToInt32(sayi1);
            int n = Convert.ToInt32(sayi2);

            Console.WriteLine(m + n);
           

            //int veri tipinden string veri tipine dönüştürme

            int sayi_1= 5;
            int sayi_2 = 10;
            string c =sayi_2.ToString();

            Console.WriteLine(c);


            //Double veri tipinden int veri tipine dönüştürme

            double sayi5 = 5.22;
            int aysun = Convert.ToInt32(sayi5);
            Console.WriteLine(sayi5);
            Console.ReadLine();

            //KULLANICIDAN Alınan değerler STRING veri tipinde döner.
            string kullanici_yas = Console.ReadLine(); //Console readline string veri tipidir.


            //Kullanıcıdan 2 tane sayı alan ve ikisinin toplamını ekrana yazdıran program

            Console.WriteLine("birinci sayiyi giriniz");
            string sayi34 = Console.ReadLine();

            Console.WriteLine("ikinci sayiyi giriniz");
            string sayi35 = Console.ReadLine();

            Console.WriteLine("İki sayinin toplami :" + sayi1 + sayi2);
            //TOplanamadı çünkü string veri tipi toplanamaz........
            Console.ReadLine();
        }


    }
}
