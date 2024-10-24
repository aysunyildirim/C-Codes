using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DEGİSKEN TANIMLADIK.byte veri tipi 0-255 arasındadır.256 olmaz.
            byte birinci = 5;
            byte ikinci = 25;
            byte ucuncu = 255;

            Console.WriteLine(birinci);
            Console.WriteLine(ikinci);
            Console.WriteLine(ucuncu);



            byte MaxDeger = byte.MaxValue;
             byte MinDeger = byte.MinValue;

            Console.WriteLine(MaxDeger);
            Console.WriteLine(MinDeger);    
            



            int birincidegisken = 15000;
            int ikincidegisken = -500000;

            Console.WriteLine(birincidegisken);
            Console.WriteLine(ikincidegisken);


            int MaxDeger1 = int.MaxValue;
            int MinDeger1 = int.MinValue;

            Console.WriteLine(MaxDeger1);    
            Console.WriteLine(MinDeger1);



            float ondaliklisayi1 = 25.56f;
            float ondaliklisayi2 = 245.76f;

            Console.WriteLine(ondaliklisayi1);
            Console.WriteLine(ondaliklisayi2);


            //Char veri tipi,Karakterleri tutmak için kullanılır.
            //Tek tırnak içerisinde tek değer olarak şekilde kullanılır.

            char karakter = 'E';

            char karakter2 = '?';

            Console.WriteLine(karakter);
            Console.WriteLine(karakter2);

            //string veri tipi içinde değerler tutar.

            string isim = "Enes";
            string soyisim = "Bayram";

            string c = "Hoşgeldiniz dersimize";

            Console.WriteLine(isim);
            Console.WriteLine(soyisim); 
            Console.WriteLine(c);


            //boolean veri tipi
            bool kontrol = true; //doğru
            bool kontrol2 = false; //yanlış

            bool sonuc = 10 > 5;

                Console.WriteLine(sonuc);

            //Object tipi bütün veri tiplerini tutar
            object a = "5";
            object aysun = "aysun";

            Console.WriteLine(aysun);
            Console.WriteLine(a);

            Console.ReadLine();
        }
    }


}
