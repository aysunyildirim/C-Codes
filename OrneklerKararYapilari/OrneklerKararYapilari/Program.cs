

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OrneklerKararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sıcaklık 30 dereceden büyükse, ekrana "Hava çok sıcak! Plaja gidip yüzebilirsin." yazdır.
            //  Sıcaklık 20 ile 30 derece arasında(20 dahil), ekrana "Hava güzel, yürüyüş yapabilirsin." yazdır.
            //Sıcaklık 10 ile 19 derece arasında(10 dahil), ekrana "Biraz serin, bir kahve içip kitap okumaya ne dersin?" yazdır.
            //Sıcaklık 0 ile 9 derece arasında(0 dahil), ekrana "Hava soğuk, kalın giyin ve dışarı çıkarken dikkat et." yazdır.
            //Sıcaklık 0'dan düşükse, ekrana "Hava çok soğuk! Dışarı çıkmak yerine evde kal ve sıcak bir şeyler iç." yazdır.

            //  Console.WriteLine("sicaklik degerini gir:"); //console.write line demek string deger demektir.klavyeden deger girdik demektir.

            // int sicaklik = Convert.ToInt32(Console.ReadLine());
            /* double sicaklik = Convert.ToDouble(Console.ReadLine()); //5 de hata vermedi tam sayılar dogal sayıları kapsar.

             if (sicaklik > 30)
             {
                 Console.WriteLine("Hava cok sıcak,Plaja gidebilirsin");

             }

             else if (sicaklik >= 20 && sicaklik < 30)
             {
                 Console.WriteLine("Hava güzel,yürüyüs yapabilirsin");

             }
             else if (sicaklik >= 10 && sicaklik < 19)
             {
                 Console.WriteLine("Biraz hava serin,bir kahve içip kitap okumaya ne dersin?");

             }
             else if (sicaklik >= 0 && sicaklik < 9)
             {
                 Console.WriteLine("Hava soguk,kalın giyin ve dısarı cıkarken dikkat et");
             }
             else
             {
                 Console.WriteLine("Hava soguk dısarı cıkma,evde zaman geçirmelisin");
             }
             Console.ReadLine(); */

            //hava 40 derece ise evde kal, dolar işareti ile,

            /* Console.WriteLine("Sicaklik degerini gir");
             double sicaklik = Convert.ToDouble(Console.ReadLine());

             if (sicaklik > 40)
             {
                 Console.WriteLine($"{sicaklik} derece ,evde kalmam gerekiyor");

             }
             else
             {
                 Console.WriteLine("Dışarı cık");
             }
             Console.ReadLine();  */

           /* Console.WriteLine("Alışveriş tutarını giriniz.");   
            double tutar = Convert.ToDouble(Console.ReadLine());

            double yeniTutar;

            if (tutar > 1000)
            {
                yeniTutar = tutar * 0.8;
            }
                else if (tutar > 500)
            {
                yeniTutar = tutar * 0.10;
                Console.WriteLine($"Alışveriş tutarınız : {tutar} tl %10 indirimli hesaplandı. Yeni tutarınız : {yeniTutar} tl  hesaplandı.");
            }
            Console.ReadLine(); */




        }
    }
}