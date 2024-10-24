
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmaOrnekleri_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan yaşını ve aylık gelirini alacak ve bu bilgilere göre kredi başvurusunu onaylayacak veya reddedecek bir program yazın. Program, if-else yapısını kullanarak aşağıdaki koşullara göre kredi başvurusunu değerlendirip uygun mesajı verecektir.

            Koşullar:
                Kullanıcının yaşı 18’den küçükse, kredi başvurusu kesinlikle reddedilir.
    Kullanıcının yaşı 18 ile 65 arasında(18 ve 65 dahil):
    Eğer kullanıcının aylık geliri 5000 TL’den fazla ise, kredi başvurusu onaylanır.
    Eğer kullanıcının aylık geliri 2000 TL ile 5000 TL arasında ise(2000 dahil), kredi başvurusu gelire göre değerlendirmeye alınır.
    Eğer kullanıcının aylık geliri 2000 TL’den az ise, kredi başvurusu reddedilir.
    Kullanıcının yaşı 65’ten büyükse, kredi başvurusu sadece:
    Aylık gelir 4000 TL’den fazla ise onaylanır.
    4000 TL veya daha az ise reddedilir.

    Beklenen Çıktı Örnekleri:
                Kullanıcı yaşı 25 ve aylık geliri 6000 TL girdiğinde: "Kredi başvurunuz onaylandı."
    Kullanıcı yaşı 17 ve aylık geliri 3000 TL girdiğinde: "Yaşınız 18'den küçük olduğu için kredi başvurunuz reddedildi."
    Kullanıcı yaşı 30 ve aylık geliri 3500 TL girdiğinde: "Kredi başvurunuz gelire göre değerlendirmeye alınmıştır."
    Kullanıcı yaşı 70 ve aylık geliri 4500 TL girdiğinde: "Kredi başvurunuz onaylandı."
    Kullanıcı yaşı 70 ve aylık geliri 3500 TL girdiğinde: "Aylık geliriniz 4000 TL'den az olduğu için kredi başvurunuz reddedildi." */



            //1.Kullanıcıdan yaş çıktısını al.
            //2.Kullanıcıdan aylık gelirini al.
            // 3.Yaş ve aylık gelirine göre kredi başvurusu alınacak

            Console.WriteLine("Kullanıcı yasini al:"); //string bir deger
            int kullaniciyasi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kullanıcı aylik gelirini hesapla");
            int aylikgelir = Convert.ToInt32(Console.ReadLine());

            //yasa gore gelir kontrolu
            if (kullaniciyasi < 18)
            {

                Console.WriteLine("Kredi basvurusu reddedilir");
            }
            else if (kullaniciyasi >= 18 && kullaniciyasi <= 65)
            {
                if (aylikgelir > 5000)
                {
                    Console.WriteLine("Kredi basvurusu onaylanır.");
                }
                else if (aylikgelir >= 2000 && aylikgelir < 5000)
                {
                    Console.WriteLine("Kredi basvurusu gelire göre hesaplanır.");

                }
            }

           else if  (kullaniciyasi > 65)
            {
                if (aylikgelir > 4000)
                {
                    Console.WriteLine("Kredi basvurusu Onaylanir");
                }
                else
                {
                    Console.WriteLine("Reddedilir.");
                }
            }


            Console.ReadLine();
        }

    }
}

