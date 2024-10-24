// See https://aka.ms/new-console-template for more information

/*400 kere aysun
string ad = "aysun";
Console.WriteLine(ad);

for (int  a = 0; a<400; a ++)
{

    Console.WriteLine(ad);
}
Console.ReadLine();
*/


// klavyeden girilen sayı kadar ekrana ibrahim yazacak. ancak klavyeden girilen sayı 4 ise bu işlemi yapsın




using System.ComponentModel.Design;



// "5",a,-9,5.2"
// '5' --> 5  
//'5' + 5
// klavyeden bir değer almamız için Console.ReadLine() kullanılır.

// klavyeden girilen herşey bir string ifadedir..
// klavyeden bir sayı gir. girilen sayı -1 olsun.
// bir değişken tanımla bu değişken "ibrahim" adını tutsun.


//1 -   bir sayı girin (girdiğin sayıyı 'sayi' değişkenine ata)--
//2- girilen 'sayi' değişkenini kontrol et. (eğer sayı 4 ise...) --
//2.1 - girilen sayı 4 değilse ekrana 'girilen sayı 4 değil' yaz.
//3- klavyeden girilen sayı kadar tekrar eden döngüyü kur ('sayi' kadar dönecek ... sayaç sayısı 3 olduğunda aysun yazacak)
//4- döngü sırasında ekrana "İbrahim" yaz.
//5- bitir.

int sayi;

Console.WriteLine("bir sayı giriniz"); // '7'
sayi = Convert.ToInt32(Console.ReadLine()); //int i converto ınt e cevirdik.console.readline string değer vermeye yardımcı oluyor.


if (sayi == 4)
{
    for (int i = 0; i < sayi; i++)
    {
        Console.WriteLine("ibrahim");
    }
}
else
{
    Console.WriteLine("girilen sayı 4 değil");
}


Console.ReadKey();




//i  sayi
//0  4   ibrahim
//1  4   ibrahim
//2  4   ibrahim
//3  4   ibrahim















Console.ReadLine();
// ctrl + k + c kodu kapatır 
//ctrl + k + u kodu açar

