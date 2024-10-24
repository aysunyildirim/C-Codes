using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrtalamayaGoreNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan 3 tane not alan ve notların ortalaması
            //eğer 8-100 arasındaysa A+
            //60-80 Arasındaysa A
            //40 dan küçük ise F yazacak
            //ctrl+k+d
            //sağ daki tip soldakine eşit olmalı.


            Console.WriteLine("Lütfen 1.notunuzu giriniz:");
            double not1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Lütfen 2.notunuzu giriniz");
            double not2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Lütfen 3.notunuzu giriniz");
            double not3 = Convert.ToDouble(Console.ReadLine());


            double ortalama = (not1 + not2 + not3) / 3;


            if (ortalama>=80 && ortalama <= 100)
            {
                Console.WriteLine("A+");
            }
            else if(ortalama>=60 && ortalama <80)
            {
                Console.WriteLine("A");
            }
            else
            {
                Console.Write("F");

            }
            
            Console.ReadLine();





            double number = 4.5;
            string number_str = number.ToString();

            string str = "a,b,c ibrahim, aysun";
            char ccc = 'a';

            string text = "123";
            int n = int.Parse(text); // hata verir

            string t1 = "12356";
            int a1 = Convert.ToInt32(t1);   // hata verir

            bool degisken_bool = true; // 1(true) yada 0(false)
            int t = Convert.ToInt32(degisken_bool);

            int krakterKodu = 65;
            char cr = Convert.ToChar(krakterKodu); 

            /*
                         bool x = false;
                        int y = int.Parse(x);

             hata verir.int.parse bir string değeri int türüne dönüştürmek için kullanılır
            eğer string değerde sayısal bir değer içeriyorsa bu sayıyı int'e dönüştürür.
            (123) hata vermez (123a) verir gibi.

             */

            string kk = "12.6";
            double k12 = double.Parse(kk);
            //int k13 = Convert.ToInt32(kk);


            double dd = 4;
            int numberddd = (int)dd;









            double aysun = 56.65;
            int a = (int)aysun;

            int aaaa = 5;
            double b = (double)aaaa;

            int s1 = 4;
            string s11 = s1.ToString();

            //ToString() sayısal bir değeri string bir değere çevirirken kullanıyoruz.
            // (int), (double) >> rakamsal değer arasında (1,23,3.5) bunlar arasında
            // cast işlemi yapacaksak bunlar kullanılır.

            double c = 5.50;
            int d = (int)c;


        }
    }
}
