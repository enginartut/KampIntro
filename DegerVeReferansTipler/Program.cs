using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1?  ; cevap=30; çünkü değerdir
            //int, double, float, bool gibi basit veri  tipleri DEĞER tiplerdir. ve Stack de yaratılırlar.

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] ? cevap = 999  cünkü dizi tarzı veri yapıları referans değerlidir.
            // Array, class, interface, gibi tipler REFERANS tiptir ve pointer gibi hareket ederler.
            /*
             new int[] ile HEAP de yeni bir integer array oluşturulur 
             int[] sayilar1 ile STACK de değişken tanımlanır.
             heap de oluşturulan array in adresi sayilar1 adlı değişkene atanır.
             sayilar1=sayilar2 ile sayilar2 nin tuttuğu aders değeri sayilar1 e atanır.
             
             */

            Console.WriteLine("Hello World!");
        }
    }
}
