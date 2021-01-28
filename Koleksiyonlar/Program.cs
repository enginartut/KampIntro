using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"bir","iki","üç","dört"};
            ////isimler[0] = "engin";
            ////isimler[1] = "yılmaz";
            ////isimler[2] = "ismail";
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            ////isimler[5] = "hasan"; 
            ////System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'
            ////hatası verir. cünkü dizi boyutu değiştirilemez.

            //isimler = new string[5];
            //// yukardakinde isimler yeni bir dizi yaratır ve bir önceki boşta kalır. 
            //// aynı değildirler. bu sebeple dizilerin yerine koleksiyonlar yaratılmıştır


            List<string> isimler2 = new List<string> { "Engin","Murat","Kerem","halil"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("süleyman");

            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

            foreach (var item in isimler2)
            {
                Console.WriteLine(item);
            }


        }
    }
}
