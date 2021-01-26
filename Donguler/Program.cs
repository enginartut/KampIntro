using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirme kursu";
            string kurs2 = "proglamaya başlangıç kursu";
            string kurs3 = "java";
            string kurs4 = "pyhton";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);

            //diziler -Array

            string[] kurslar = new string[] { "yazılım geliştirme kursu","proglamaya başlangıç kursu", "java","python","C++" };

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("========for bitti============");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu -- footer");

        }
    }
}
