using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArttirmaAzaltma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 20;
           
            sayi--;
            Console.WriteLine(sayi);    



            //Atama operatörü -Sagdaki değeri alıp soldaki değere atar.
            int Z = 21;

            //Eşittir operatörü
            int sayiA = 4;
            int sayiB = 5;
            bool kontrolEt = sayiA== sayiB;
            Console.WriteLine(kontrolEt);


            int yas = 17;
            bool KontrolEt = yas > 18;
            Console.WriteLine(kontrolEt);

            //Değil operatörü !
            bool a = true;
            Console.WriteLine(!a);



            //Ek operatörler
            int  y= 5;
            y = y / 5;
          

            Console.WriteLine("y nın değeri:" + y);

            Console.ReadLine();
        }
    }
}
